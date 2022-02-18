using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Threading;

public class CameraManager : Singleton<CameraManager>
{
    [Header("Post Procssing")]
    [SerializeField] VolumeProfile Volume;
    Vignette vignette;
    FilmGrain grain;
    DepthOfField depthOfField;
    ColorAdjustments ColorAdjustments;
    Bloom bloom;

    [Header("Camera")]
    [SerializeField] Player player;
    bool isBed;
    public bool isUIon;
    float Timer;
    float PlayerTimer;
    void Start()
    {
        player = FindObjectOfType<Player>();
        Volume.TryGet<ColorAdjustments>(out ColorAdjustments);
        Volume.TryGet<Vignette>(out vignette);
        Volume.TryGet<FilmGrain>(out grain);
        Volume.TryGet<DepthOfField>(out depthOfField);
        Volume.TryGet<Bloom>(out bloom);

    }
    private void OnLevelWasLoaded(int level)
    {
        player = FindObjectOfType<Player>();
        if (SceneManager.GetActiveScene().name != "TitleMap")
        {
            transform.position = player.transform.position;
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleMap")
        {
            if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0) || Input.anyKeyDown)
            {
                Timer = 10;
            }
            if (Timer > 0)
            {
                if (PlayerTimer > 5)
                {
                    Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5, Time.deltaTime);
                    FollowPlayer();
                }
                else if (isUIon == false)
                {
                    ZoomOut();
                    PlayerTimer += Time.deltaTime;
                }
            }
            else if(SceneManager.GetActiveScene().name != "Mario")
            {
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5, Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, 13, -10), Time.deltaTime);
            }
            if(!FindObjectOfType<MainTitle>().StopPlayer)
            Timer -= Time.deltaTime;
        }
        else
        {
            FollowPlayer();
        }
    }

    void ZoomOut()
    {
        Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 8, Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, 7, -10), Time.deltaTime);
    }
    void FollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, player.gameObject.transform.position + new Vector3(0, 0, -10), Time.deltaTime);
    }
    private void OnApplicationQuit()
    {
        VolumeReset();
    }
    void VolumeReset()
    {
        vignette.intensity.value = 0;
        grain.intensity.value = 0;
        depthOfField.mode.value = 0;
        bloom.intensity.value = 0;

    }

    public async void BedEvent()
    {
        while (vignette.intensity.value != 1)
        {
            vignette.intensity.value += 0.01f;
            ColorAdjustments.active = true;
            await Task.Delay(15);
            //yield return new WaitForSeconds(0.015f);
        }
        SceneManager.LoadScene("PlaygroundMap");
        await Task.Delay(100);
        //yield return new WaitForSeconds(1);
        ColorAdjustments.active = false;
        while (vignette.intensity.value != 0)
        {
            vignette.intensity.value -= 0.01f;
            await Task.Delay(15);
            //yield return new WaitForSeconds(0.015f);
        }
        TalkUIManager.Instance.IsTalk = false;
    }
}

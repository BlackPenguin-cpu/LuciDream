using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class CameraManager : Singleton<CameraManager>
{
    [Header("Post Procssing")]
    [SerializeField] VolumeProfile Volume;
    public Vignette vignette;
    public FilmGrain grain;
    public DepthOfField depthOfField;
    public Bloom bloom;

    [Header("Camera")]
    [SerializeField] Player player;
    float Timer;
    float PlayerTimer;
    void Start()
    {
        player = FindObjectOfType<Player>();
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
                else
                {
                    ZoomOut();
                    PlayerTimer += Time.deltaTime;
                }
            }
            else
            {
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5, Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, 13, -10), Time.deltaTime);
            }
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
}

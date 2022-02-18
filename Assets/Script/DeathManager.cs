using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using System.Threading.Tasks;

[System.Serializable]
public class DeathResources
{
    public int num;
    public Sprite Image;
    [TextArea]
    public string Text;
}

public class DeathManager : Singleton<DeathManager>
{
    public List<DeathResources> DeathList;
    [Header("ø¨√‚")]
    [SerializeField] VolumeProfile volume;
    [SerializeField] Canvas DeathUI;
    [SerializeField] Image Deathimage;
    [SerializeField] Image Photo;
    [SerializeField] TextMeshProUGUI number;
    [SerializeField] TextMeshProUGUI Description;
    Vignette vignette;

    public IEnumerator ShooseDie()
    {
        yield return new WaitForSeconds(1);
        Player.Instance.Dead = true;

        volume.TryGet(out vignette);
        vignette.color.value = new Color(0, 0, 0, 0.5f);
        StartCoroutine(RollingGirl());
        while (vignette.intensity.value < 0.5f)
        {
            vignette.intensity.value += 0.001f;
            yield return new WaitForSeconds(0.02f);
        }

        vignette.intensity.value = 1;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator RollingGirl()
    {
        Rigidbody2D rigid = Player.Instance.GetComponent<Rigidbody2D>();
        rigid.bodyType = RigidbodyType2D.Dynamic;
        rigid.gravityScale = 0.3f;
        for (int i = 0; i < 10; i++)
        {
            rigid.velocity = new Vector2(0, 0);
            rigid.angularVelocity = 0;
            rigid.AddForce(new Vector3(-1f, 2, 0), ForceMode2D.Impulse);
            rigid.AddTorque(-5f, ForceMode2D.Impulse);
            yield return new WaitForSeconds(2);
        }
    }
    public IEnumerator DeathNote()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator amongDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator portalDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator CreeperDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator ChickenDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public IEnumerator ButtonDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
        OnDeathUI(DeathList[1]);
    }
    public void OnDeathUI(int num,string text)
    {
        Photo.transform.DOMoveY(0, 0).SetEase(Ease.InOutBack);

        onDeadReset();
        Player.Instance.Dead = true;
        AlbumManager.Instance.gameObject.SetActive(true);
        AlbumManager.Instance.unlock[num] = true;
        AlbumManager.Instance.explanation[num] = text;
        AlbumManager.Instance.Save();

        DeathUI.gameObject.SetActive(true);
        number.text = "# " + num;
        Description.text = text;

    }

    public void OnDeathUI(DeathResources List)
    {
        Photo.transform.DOMoveY(0, 0).SetEase(Ease.InOutBack);

        Player.Instance.CoroutineQuit();

        onDeadReset();
        Player.Instance.Dead = true;
        AlbumManager.Instance.gameObject.SetActive(true);
        AlbumManager.Instance.image[List.num] = List.Image;
        AlbumManager.Instance.unlock[List.num] = true;
        AlbumManager.Instance.explanation[List.num] = List.Text;
        AlbumManager.Instance.Save();

        DeathUI.gameObject.SetActive(true);
        Deathimage.sprite = List.Image;
        number.text = "# " + List.num;
        Description.text = List.Text;

    }

    public async void UIOff()
    {
        Photo.transform.DOMoveY(0, 8);
        DeathUI.gameObject.SetActive(false);

        Player.Instance.transform.position = new Vector3(0, 2, 0);
        Camera.main.transform.position = new Vector3(0, 2, -10);
        CameraManager.Instance.Volume.Reset();
        Player.Instance.CoroutineQuit();
        Player.Instance.Dead = false;

        float alpah = 0;
        while(CameraManager.Instance.BlackScreen.color.a < 1)
        {
            CameraManager.Instance.BlackScreen.color = new Color(0, 0, 0, alpah);
            alpah += 0.01f;
            await Task.Delay(10);
        }
        
        SceneManager.LoadScene("TitleMap");
        while (CameraManager.Instance.BlackScreen.color.a > 0)
        {
            CameraManager.Instance.BlackScreen.color = new Color(0, 0, 0, alpah);
            alpah -= 0.01f;
            await Task.Delay(10);
        }

    }

    private void Update()
    {
        if (DeathUI.gameObject.activeSelf == true)
        {
            if (Input.anyKey || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) UIOff();
        }
    }
    private void onDeadReset()
    {
        volume.Reset();
    }
}

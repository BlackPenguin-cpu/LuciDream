using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DeathManager : Singleton<DeathManager>
{
    [SerializeField] VolumeProfile volume;
    [SerializeField] Canvas DeathUI;
    [SerializeField] Image Photo;
    [SerializeField] TextMeshProUGUI number;
    [SerializeField] TextMeshProUGUI Description;
    Vignette vignette;

    public IEnumerator ShooseDie()
    {
        yield return new WaitForSeconds(1);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 1;
    }
    public IEnumerator DeathNote()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
    }
    public IEnumerator amongDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
    }
    public IEnumerator portalDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
    }
    public IEnumerator CreeperDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
    }
    public IEnumerator ChickenDie()
    {
        yield return new WaitForSeconds(5);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet(out vignette);

        vignette.intensity.value = 5;
    }
    public void OnDeathUI(int num, Sprite image, string Text)
    {
        AlbumManager.Instance.gameObject.SetActive(true);
        AlbumManager.Instance.image[num] = image;
        AlbumManager.Instance.unlock[num] = true;
        AlbumManager.Instance.explanation[num] = Text;

        /*Photo.sprite = image;
        number.text = "# " + num;
        Description.text = Text;*/

        //여따가 num은 번호 image는 이미지 Text는 설명이니까 알아서 적용시켜^^

    }

    public void UIOff()
    {
        DeathUI.gameObject.SetActive(false);

        Player.Instance.transform.position = new Vector3(0, 2, 0);
        SceneManager.LoadScene("TitleMap");
    }
}

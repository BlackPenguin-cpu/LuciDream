using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedObject : Objects
{
    public GameObject BedUI;
    public override void Interaction()
    {
        base.Interaction();
        BedUI.SetActive(true);
    }

    public void GameStart()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        while (CameraManager.Instance.vignette.intensity.value != 1)
        {
            CameraManager.Instance.vignette.intensity.value += 0.01f;
            yield return new WaitForSeconds(0.015f);
        }
        SceneManager.LoadScene("Map");
        while (CameraManager.Instance.vignette.intensity.value != 0)
        {
            CameraManager.Instance.vignette.intensity.value -= 0.01f;
            yield return new WaitForSeconds(0.015f);
        }
    }
}


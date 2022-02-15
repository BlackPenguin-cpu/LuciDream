using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DeathManager : Singleton<DeathManager>
{
    [SerializeField] VolumeProfile volume;
    [SerializeField] Canvas DeathUI;
    [SerializeField] TextMeshProUGUI number;
    [SerializeField] TextMeshProUGUI Description;
    Vignette vignette;

    public IEnumerator ShooseDie()
    {
        yield return new WaitForSeconds(1);
        Player.Instance._State = PlayerState.DIE;

        volume.TryGet<Vignette>(out vignette);

        vignette.intensity.value = 1;
    }

    public void OnDeathUI(int number,Image image, string Text)
    {

    }
}

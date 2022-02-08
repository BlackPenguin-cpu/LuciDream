using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DeathManager : Singleton<DeathManager>
{
    [SerializeField] VolumeProfile volume;
    Vignette vignette;

    private void Start()
    {
        StartCoroutine(ShooseDie());
    }
    public IEnumerator ShooseDie()
    {
        yield return new WaitForSeconds(1);
        //Player.Instance._State = PlayerState.DIE;

        volume.TryGet<Vignette>(out vignette);

        vignette.intensity.value = 1;
    }

}

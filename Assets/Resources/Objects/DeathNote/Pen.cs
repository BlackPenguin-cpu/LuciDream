using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : Misc
{
    void Start()
    {
        StartCoroutine(Hide());

    }

    public override void Interaction()
    {
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(10);
        this.gameObject.SetActive(false);
    }
}

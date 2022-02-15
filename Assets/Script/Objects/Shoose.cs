using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoose : Misc
{
    // Start is called before the first frame update
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

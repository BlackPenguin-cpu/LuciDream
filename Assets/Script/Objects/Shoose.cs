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
        base.Interaction();
        StartCoroutine(Hide());
    }
    protected override IEnumerator TextPrint()
    {
        yield return base.TextPrint();

    }

    IEnumerator Hide()
    {

        yield return new WaitForSeconds(10);
        this.gameObject.SetActive(false);
    }
}


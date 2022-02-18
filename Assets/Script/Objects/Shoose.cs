using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoose : Misc
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        if (Inventory.Instance.Shoose) gameObject.SetActive(false);
    }

    public override void Interaction()
    {
        base.Interaction();
    }
    protected override IEnumerator TextPrint()
    {
        yield return StartCoroutine(base.TextPrint());
        Inventory.Instance.Shoose = true;
        this.gameObject.SetActive(false);
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingPoster : Misc
{
    protected override void Start()
    {
        base.Start();
    }
    void Check()
    {
        Inventory.Instance.MissingPoster++;
    }

    protected override IEnumerator TextPrint()
    {
        yield return new WaitForSeconds(1);
        base.TextPrint();
    }
}

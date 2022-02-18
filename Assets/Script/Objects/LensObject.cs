using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensObject : Objects
{
    public GameObject UI;
    public override void Interaction()
    {
        base.Interaction();
        UI.GetComponent<ArrowKeyManager>().Click();
    }
}

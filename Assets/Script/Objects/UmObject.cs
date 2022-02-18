using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmObject : Objects
{
    public Sprite um2;
    public override void Interaction()
    {
        base.Interaction();
        GetComponent<SpriteRenderer>().sprite = um2;
    }
}

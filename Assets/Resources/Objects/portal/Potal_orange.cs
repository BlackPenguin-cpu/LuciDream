using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potal_orange : Objects
{
    public override void Interaction()
    {
        gameObject.transform.position = new Vector3(7, -0.55f, -1);
    }
}

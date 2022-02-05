using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskObject : Objects
{
    public GameObject Option;
    public override void Interaction()
    {
        Option.SetActive(true);
    }



}

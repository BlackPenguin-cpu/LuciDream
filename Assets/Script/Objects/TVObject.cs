using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVObject : Objects
{
    public GameObject Album;

    public override void Interaction()
    {
        Album.SetActive(true);
    }

}

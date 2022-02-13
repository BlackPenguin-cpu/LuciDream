using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorObject : Objects
{
    public GameObject Door;
    public List<Sprite> DoorImage;
    public int State = 1;
    public override void Interaction()
    {
        base.Interaction();
        if (State == 0)
        {
            State = 1;
        }
        else
        {
            State = 0;
        }
        Door.GetComponent<SpriteRenderer>().sprite = DoorImage[State];
    }
}

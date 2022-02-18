using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teemo : Objects
{
    public int number;
    public string text;
    public override void Interaction()
    {
        base.Interaction();
        DeathManager.Instance.OnDeathUI(number, text);
    }
}

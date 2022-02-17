using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : Objects
{
    public Sprite image;
    public string text;
    public int number;
    public override void Interaction()
    {
        base.Interaction();
        DeathManager.Instance.OnDeathUI(number, image, text);
    }
}

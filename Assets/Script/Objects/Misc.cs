using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misc : Objects
{
    public string Name;
    public List<string> Speech;

    protected override void Interaction()
    {

        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }

}

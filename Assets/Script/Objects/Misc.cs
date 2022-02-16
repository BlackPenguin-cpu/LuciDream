using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misc : Objects
{
    public string Name;
    public List<string> Speech;
    public override void Interaction()
    {     
        base.Interaction();
        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}

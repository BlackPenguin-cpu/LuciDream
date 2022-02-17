using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine2 : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject mine;
    public override void Interaction()
    {
        if(mine.GetComponent<Mine>().chek == true)
        {
            base.Interaction();
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
    }
    IEnumerator enumerator()
    {
        if (mine.GetComponent<Mine>().chek == true)
        {
            yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
    }
}

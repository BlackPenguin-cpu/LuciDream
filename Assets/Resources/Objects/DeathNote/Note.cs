using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject MainCamera;
    public override void Interaction()
    {
        if(MainCamera.GetComponent<Inventory>().pen == false)
        {
            base.Interaction();
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
        else
        {
            MainCamera.GetComponent<Inventory>().note = true;
        }
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}

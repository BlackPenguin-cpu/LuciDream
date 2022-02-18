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
        base.Interaction();
        if (MainCamera.GetComponent<Inventory>().pen == false)
        {
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
        else
        {
            Invoke("note", 1);
            MainCamera.GetComponent<Inventory>().note = true;
        }
    }
    void note()
    {
        SoundManager.Instance.PlaySound("deathnotea");
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}

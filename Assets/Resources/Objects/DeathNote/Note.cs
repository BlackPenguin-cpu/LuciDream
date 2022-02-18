using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : Objects
{
    public string Name;
    public List<string> Speech;
    public override void Interaction()
    {
        base.Interaction();
        if (Inventory.Instance.pen == false)
        {
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
        else
        {
            Invoke("note", 1);
            SoundManager.Instance.PlaySound("deathnotea");
        }
    }
    void note()
    {
        DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[5]);
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}

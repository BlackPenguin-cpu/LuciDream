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
            SoundManager.Instance.PlaySound("deathnotea");
            //  GetComponent<Player>()._State = PlayerState.DIE;
            Invoke("Die", 3);
            Invoke("note", 4);
        }
    }
    void Die()
    {
        Player.Instance._State = PlayerState.DIE;
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

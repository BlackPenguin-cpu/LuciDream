using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misc : Objects
{
    public string Name;
    public List<string> Speech;

    public override void Interaction()
    {
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {

        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        if (gameObject.name == "shoose")
        {
            this.gameObject.SetActive(false);
        }
    }
}

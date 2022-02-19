using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmongMic : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public bool Ok;
    protected override void Start()
    {
        base.Start();
        Ok = false;
        Talk2.SetActive(false);
        Talk3.SetActive(false);
        Talk1.SetActive(true);

        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
    public override void Interaction()
    {
        base.Interaction();
    }
    private void Update()
    {
        if (TalkUIManager.Instance.a == 1)
        {
            Talk1.SetActive(false);
            Talk2.SetActive(true);
        }
        else if (TalkUIManager.Instance.a == 2)
        {
            Talk2.SetActive(false);
            Talk3.SetActive(true);
        }
        else if (TalkUIManager.Instance.a > 2)
        {
            Talk1.SetActive(true);
            Talk2.SetActive(true);
            Talk3.SetActive(true);
            Ok = true;
        }
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}

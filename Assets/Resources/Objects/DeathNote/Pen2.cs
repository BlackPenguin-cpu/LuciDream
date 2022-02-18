using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen2 : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject pen;
    bool mineyes = true;
    public GameObject Image;
    public bool chek = false;
    public GameObject Pentable;

    protected override void Start()
    {
        base.Start();
        pen.SetActive(true);
        Image.SetActive(false);
    }
    public override void Interaction()
    {
        base.Interaction();
        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        Invoke("aaa", 1.5f);
    }
    void aaa()
    {
        Image.SetActive(true);
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
    public void yes()
    {
        chek = true;
        Inventory.Instance.pen = true;
        Image.SetActive(false);
    }

    public void no()
    {
        Image.SetActive(false);
    }
}

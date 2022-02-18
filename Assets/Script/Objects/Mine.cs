using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject mine;
    bool mineyes = true;
    public GameObject Image;
    public bool chek = false;
    public GameObject MainCamera;

    protected override void Start()
    {
        base.Start();
        mine.SetActive(true);
        Image.SetActive(false);
    }
    public override void Interaction()
    {
        base.Interaction();
        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        if (Input.GetMouseButtonUp(0))
        {
            Image.SetActive(true);
        }
    }
    IEnumerator enumerator()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
    public void yes()
    {
        chek = true;
        MainCamera.GetComponent<Inventory>().minem = true;
        Image.SetActive(false);
    }

    public void no()
    {
        Image.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject mine;
    public GameObject Car;

    protected override void Start()
    {
        base.Start();
        mine.SetActive(false);
        Car.SetActive(true);
    }
    public override void Interaction()
    {
        base.Interaction();
        if (Inventory.Instance.minem == false)
        {
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
        else
        {
            mine.SetActive(true);
        }
    }
    IEnumerator enumerator()
    {
      yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }

    public void CarScrach()
    {
        Car.SetActive(false);
        print("ddd");
    }

    public void no()
    {
        mine.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : Objects
{
    public string Name;
    public List<string> Speech;
    public GameObject MainCamera;
    public GameObject mine;
    public GameObject Car;

    private void Start()
    {
        mine.SetActive(false);
        Car.SetActive(true);
    }
    public override void Interaction()
    {
        if (MainCamera.GetComponent<Inventory>().minem == false)
        {
            base.Interaction();
            StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
        else
        {
            mine.SetActive(true);
            Time.timeScale = 0;
        }
    }
    IEnumerator enumerator()
    {
        if (MainCamera.GetComponent<Inventory>().minem == false)
        {
            yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        }
    }

    public void CarScrach()
    {
        Car.SetActive(false);
        Time.timeScale = 1;
    }

    public void no()
    {
        mine.SetActive(false);
        Time.timeScale = 1;
    }
}

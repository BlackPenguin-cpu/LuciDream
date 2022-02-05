using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkUIManager : Singleton<TalkUIManager>
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI SpeechText;
    public float delay;
    public GameObject EndCusor;
    private bool IsClick = false;
    public GameObject Box;

    void Start()
    {
        //StartCoroutine(TextScript());
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            IsClick = true;
        }
    }
    public IEnumerator TextScript(string Name, List<string> Speech)
    {
        Box.SetActive(true);
        if (Name == null)
        {
            Name = "";
        }
        foreach (string str in Speech)
        {
            yield return StartCoroutine(Talk(Name, str));

        }
        Box.SetActive(false);
    }
    IEnumerator Talk(string name, string speech)
    {
        IsClick = false;
        EndCusor.SetActive(false);
        var wait = new WaitForSeconds(delay);
        NameText.text = name;
        SpeechText.text = "";

        foreach (var letter in speech)
        {
            if (IsClick)
            {
                SpeechText.text = speech;
                break;
            }
            SoundManager.Instance.PlaySound("TalkSound");
            SpeechText.text += letter;
            yield return wait;
        }
        EndCusor.SetActive(true);
        while (!Input.GetMouseButtonUp(0))
        {
            yield return 0;
        }
    }

}

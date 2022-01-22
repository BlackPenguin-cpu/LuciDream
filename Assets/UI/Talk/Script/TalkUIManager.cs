using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkUIManager : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI SpeechText;
    private string Array;
    public float delay;
    public GameObject EndCusor;

    void Start()
    {
        StartCoroutine(TextScript());
    }

    void Update()
    {

    }
    IEnumerator TextScript()
    {
        yield return StartCoroutine(Talk("???", "인간의 70%는 물로 이루어져 있다. 그럼 여기서 다른 생각을 해볼 수 있다."));
        yield return StartCoroutine(Talk("???", "인간의 70%가 물이라면 사람이 10명 모였을 때 7명은 물인가?"));
        yield return StartCoroutine(Talk("???", "그렇다 디럭스 붐버 ☆★☆★☆★☆★"));
    }
    IEnumerator Talk(string name, string speech)
    {
        EndCusor.SetActive(false);
        var wait = new WaitForSeconds(delay);
        int a = 0;
        NameText.text = name;
        Array = "";

        for (a = 0; a < speech.Length; a++)
        {
            Array += speech[a];
            SpeechText.text = Array;
            yield return wait;
        }
        EndCusor.SetActive(true);
        while (!Input.GetMouseButtonUp(0))
        {
            yield return 0;
        }
    }

}

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

    void Start()
    {
        StartCoroutine(TextScript());
    }

    void Update()
    {

    }
    IEnumerator TextScript()
    {
        yield return StartCoroutine(Talk("???", "�ΰ��� 70%�� ���� �̷���� �ִ�. �׷� ���⼭ �ٸ� ������ �غ� �� �ִ�."));
        yield return StartCoroutine(Talk("???", "�ΰ��� 70%�� ���̶�� ����� 10�� ���� �� 7���� ���ΰ�?"));
        yield return StartCoroutine(Talk("???", "�׷��� �𷰽� �չ� �١ڡ١ڡ١ڡ١�"));
    }
    IEnumerator Talk(string name, string speech)
    {
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

        while (!Input.GetMouseButtonUp(0))
        {
            yield return 0;
        }
    }

}

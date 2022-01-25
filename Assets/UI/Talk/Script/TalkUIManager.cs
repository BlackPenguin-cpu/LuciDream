using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkUIManager : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI SpeechText;
    public float delay;
    public GameObject EndCusor;
    private bool IsClick = false;

    void Start()
    {
        StartCoroutine(TextScript());
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            IsClick = true;
        }
    }
    IEnumerator TextScript()
    {
        yield return StartCoroutine(Talk("???", "�ΰ��� 70%�� ���� �̷���� �ִ�. �׷� ���⼭ �ٸ� ������ �غ� �� �ִ�."));
        yield return StartCoroutine(Talk("???", "�ΰ��� 70%�� ���̶�� ����� 10�� ���� �� 7���� ���ΰ�?"));
        yield return StartCoroutine(Talk("???", "�׷��� �𷰽� �չ� �١ڡ١ڡ١ڡ١�"));
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

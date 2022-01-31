using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class NumberPad : MonoBehaviour
{
    public TextMeshProUGUI NumberBoard;
    public GameObject numberpad;
    public Image BackGround;
    public string Password;
    private bool AnswerCheck = true;
    void Start()
    {
    }

    void Update()
    {
        PasswordCheck();
    }

    public void NumberButtonClick(int Number)
    {
        if (NumberBoard.text.Length < 4)
        {
            NumberBoard.text += Number;
        }
    }

    public void BackSpaceButtonClick()
    {
        if (NumberBoard.text.Length != 0)
        {
            NumberBoard.text = NumberBoard.text.Substring(0, NumberBoard.text.Length - 1);
            AnswerCheck = true;
        }
    }

    void PasswordCheck()
    {
        if (NumberBoard.text.Length == 4 && AnswerCheck)
        {
            AnswerCheck = false;
            if (NumberBoard.text == Password)
            {
                Debug.Log("맞음!!");
                StartCoroutine(ClearDirecting());
            }
            else
            {
                Debug.Log("틀림!!");
                StartCoroutine(OverDireCting());
            }
        }
    }

    public void CloseButtonClick()
    {
        numberpad.transform.DOMove(new Vector3(960, 1540, 0), 1).SetEase(Ease.InBack);
        NumberBoard.text = "";
        AnswerCheck = true;
    }

    public void MoveButtonClick()
    {
        numberpad.transform.DOMove(new Vector3(960, 540, 0), 1).SetEase(Ease.OutBack);
    }

    IEnumerator ClearDirecting()
    {
        BackGround.color = new Color(0, 255, 0, 0);
        WaitForSeconds Wait = new WaitForSeconds(0.01f);
        Color Green = new Color(0, 1 * Time.deltaTime, 0, 1 * Time.deltaTime);
        while (BackGround.color.a <= 0.4f)
        {
            BackGround.color += Green;
            yield return Wait;
        }
        BackGround.color = new Color(0, 0, 0, 0);
    }

    IEnumerator OverDireCting()
    {
        BackGround.color = new Color(255, 0, 0, 0);
        WaitForSeconds Wait = new WaitForSeconds(0.01f);
        Color Red = new Color(0, 0, 0, 1 * Time.deltaTime);
        while (BackGround.color.a <= 0.4f)
        {
            BackGround.color += Red;
            yield return Wait;
        }
        BackGround.color = new Color(0, 0, 0, 0);
    }
}


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberPad : MonoBehaviour
{
    public TextMeshProUGUI NumberBoard;
    public string Password;
    void Start()
    {
    }

    void Update()
    {
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
        NumberBoard.text = NumberBoard.text.Substring(0, NumberBoard.text.Length - 1);
    }

    public void OKButtonClick()
    {
        if (NumberBoard.text == Password)
        {
            Debug.Log("맞음!!");
        }
        else
        {
            Debug.Log("틀림!!");
        }
    }
}

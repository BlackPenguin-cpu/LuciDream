using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    float a = 0;
    float i = 0;
    int c = 0;
    public InputField answer;
    public Text number1;
    public Text number2;
    public GameObject good;
    public GameObject bad;

    void Start()
    {
        aaa();
        good.SetActive(false);
        bad.SetActive(false);
    }

    public void Update()
    {

    }

    void aaa()
    {
        if (i < 3)
        {
            off();
            float random = Random.Range(1, 10);
            number1.text = random.ToString();

            float random2 = Random.Range(1, 10);
            number2.text = random2.ToString();
            a = random * random2;
        }
    }

    public void Cheak()
    {
        string s = answer.text;
        c = int.Parse(s);
        if (c == a)
        {
            good.SetActive(true);
            i++;
            answer.text = "";
            Invoke("aaa", 1);
        }
        else
        {
            bad.SetActive(true);
            answer.text = "";
            Invoke("aaa", 1);
        }
        if(i == 3)
        {
            print("good");
        }
    }

    void off()
    {
        good.SetActive(false);
        bad.SetActive(false);
    }
}
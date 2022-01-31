using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memory : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public GameObject blue;
    public GameObject orange;
    public GameObject pink;
    public GameObject mint;
    public GameObject black;
    public GameObject purple;
    int i = 0;
    int a = 0;
    int b = 0;
    int Red = 0;
    int Yellow = 0;
    int Green = 0;
    int Blue = 0;
    int Orange = 0;
    int Pink = 0;
    int Mint = 0;
    int Black = 0;
    int Purple = 0;
    public bool On = false;
       
    void Start()
    {
        Delete();
        Randoma();
    }
    void Randoma()
    {
        float random = Random.Range(1, 2);
        print(random);
        if(i < 3)
        {
            switch (random)
            {
                case 1:
                    red.SetActive(true);
                    i++;
                    Red = 1;
                    break;
                case 2:
                    yellow.SetActive(true);
                    i++;
                    Yellow = 1;
                    break;
                case 3:
                    green.SetActive(true);
                    i++;
                    Green = 1;
                    break;
                case 4:
                    blue.SetActive(true);
                    i++;
                    Blue = 1;
                    break;
                case 5:
                    orange.SetActive(true);
                    i++;
                    Orange = 1;
                    break;
                case 6:
                    pink.SetActive(true);
                    i++;
                    Pink = 1;
                    break;
                case 7:
                    mint.SetActive(true);
                    i++;
                    Mint = 1;
                    break;
                case 8:
                    black.SetActive(true);
                    i++;
                    Black = 1;
                    break;
                case 9:
                    purple.SetActive(true);
                    i++;
                    Purple = 1;
                    break;
            }
            Invoke("Delete", 2);
            Invoke("aaa", 3);
        }
        else
        {
            On = true;
            bbb();         
        }
    }
    public void Delete()
    {
        red.SetActive(false);
        yellow.SetActive(false);
        green.SetActive(false);
        blue.SetActive(false);
        orange.SetActive(false);
        pink.SetActive(false);
        mint.SetActive(false);
        black.SetActive(false);
        purple.SetActive(false);
    }
    void aaa()
    {
        Randoma();
    }

    void bbb()
    {
        red.SetActive(true);
        yellow.SetActive(true);
        green.SetActive(true);
        blue.SetActive(true);
        orange.SetActive(true);
        pink.SetActive(true);
        mint.SetActive(true);
        black.SetActive(true);
        purple.SetActive(true);
    }

    private void Update()
    {
        if(b >= 3)
        {
            if (a >= 3)
            {
                print("good");
            }
            else print("bad");
        }
    }
    public void Reda()
    {
        b++;
        if (Red == 1)
        {
            a += Red;
            Red = 0;
        }
    }
    public void Yellowa()
    {
        b++;
        if (Yellow == 1)
        {
            a += Yellow;
            Yellow = 0;
        }
    }
    public void Greena()
    {
        b++;
        if (Green == 1)
        {
            a += Green;
            Green = 0;
        }
    }
    public void Bluea()
    {
        b++;
        if (Blue == 1)
        {
            a += Blue;
            Blue = 0;
        }
    }
    public void Orangea()
    {
        b++;
        if (Orange == 1)
        {
            a += Orange;
            Orange = 0;
        }
    }
    public void Pinka()
    {
        b++;
        if (Pink == 1)
        {
            a += Pink;
            Pink = 0;
        }
    }
    public void Minta()
    {
        b++;
        if (Mint == 1)
        {
            a += Mint;
            Mint = 0;
        }
    }
    public void Blacka()
    {
        b++;
        if (Black == 1)
        {
            a += Black;
            Black = 0;
        }
    }
    public void Purplea()
    {
        b++;
        if (Purple == 1)
        {
            a += Purple;
            Purple = 0;
        }
    }
}

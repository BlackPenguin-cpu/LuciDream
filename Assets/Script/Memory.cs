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
    public GameObject red1;
    public GameObject yellow1;
    public GameObject green1;
    public GameObject blue1;
    public GameObject orange1;
    public GameObject pink1;
    public GameObject mint1;
    public GameObject black1;
    public GameObject purple1;
    public GameObject Good;
    public GameObject Bad;

    int i = 0;
    int a = 0;
    int b = 0;
    int c = 3;
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
        float random = Random.Range(1, 10);
        if(c > i)
        {
            switch (random)
            {
                case 1:
                    red.SetActive(true);
                    red1.SetActive(true);
                    i++;
                    Red++;
                    break;
                case 2:
                    yellow.SetActive(true);
                    yellow1.SetActive(true);
                    i++;
                    Yellow++;
                    break;
                case 3:
                    green.SetActive(true);
                    green1.SetActive(true);
                    i++;
                    Green++;
                    break;
                case 4:
                    blue.SetActive(true);
                    blue1.SetActive(true);
                    i++;
                    Blue++;
                    break;
                case 5:
                    orange.SetActive(true);
                    orange1.SetActive(true);
                    i++;
                    Orange++;
                    break;
                case 6:
                    pink.SetActive(true);
                    pink1.SetActive(true);
                    i++;
                    Pink++;
                    break;
                case 7:
                    mint.SetActive(true);
                    mint1.SetActive(true);
                    i++;
                    Mint++;
                    break;
                case 8:
                    black.SetActive(true);
                    black1.SetActive(true);
                    i++;
                    Black++;
                    break;
                case 9:
                    purple.SetActive(true);
                    purple1.SetActive(true);
                    i++;
                    Purple++;
                    break;
            }
            Invoke("Delete", 1);
            Invoke("aaa", 2);
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

        red1.SetActive(false);
        yellow1.SetActive(false);
        green1.SetActive(false);
        blue1.SetActive(false);
        orange1.SetActive(false);
        pink1.SetActive(false);
        mint1.SetActive(false);
        black1.SetActive(false);
        purple1.SetActive(false);

        Good.SetActive(false);
        Bad.SetActive(false);
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

        red1.SetActive(true);
        yellow1.SetActive(true);
        green1.SetActive(true);
        blue1.SetActive(true);
        orange1.SetActive(true);
        pink1.SetActive(true);
        mint1.SetActive(true);
        black1.SetActive(true);
        purple1.SetActive(true);
    }

    void Clear()
    {
        if (b >= c)
        {
            if (a == c)
            {
                Good.SetActive(true);
                Invoke("good", 2);
            }
            else
            {
                Bad.SetActive(true);
                Invoke("bad", 2);
            }
        }
    }

    void good()
    {
        Good.SetActive(false);
        c++;
        b = 0;
        a = 0;
        i = 0;
        Delete();
        On = false;
        Invoke("aaa", 1);
    }

    void bad()
    {
        Bad.SetActive (false);
        b = 0;
        a = 0;
        i = 0;
        Delete();
        On = false;
        Invoke("aaa", 1);
    }
    public void Reda()
    {
        b++;
        if (Red == 1)
        {
            a += Red;
            Red--;
            Clear();
        }
        else if (Red > 1)
        {
            a += 1;
            Red--;
            Clear();
        }
    }
    public void Yellowa()
    {
        b++;
        if (Yellow == 1)
        {
            a += Yellow;
            Yellow--;
            Clear();
        }
        else if (Yellow > 1)
        {
            a += 1;
            Yellow--;
            Clear();
        }
    }
    public void Greena()
    {
        b++;
        if (Green == 1)
        {
            a += Green;
            Green--;
            Clear();
        }
        else if(Green > 1)
        {
            a += 1;
            Green--;
            Clear();
        }
    }
    public void Bluea()
    {
        b++;
        if (Blue == 1)
        {
            a += Blue;
            Blue--;
            Clear();
        }
        else if (Blue > 1)
        {
            a += 1;
            Blue--;
            Clear();
        }
    }
    public void Orangea()
    {
        b++;
        if (Orange == 1)
        {
            a += Orange;
            Orange--;
            Clear();
        }
        else if (Orange > 1)
        {
            a += 1;
            Orange--;
            Clear();
        }
    }
    public void Pinka()
    {
        b++;
        if (Pink == 1)
        {
            a += Pink;
            Pink--;
            Clear();
        }
        else if (Pink > 1)
        {
            a += 1;
            Pink--;
            Clear();
        }
    }
    public void Minta()
    {
        b++;
        if (Mint == 1)
        {
            a += Mint;
            Mint--;
            Clear();
        }
        else if (Mint > 1)
        {
            a += 1;
            Mint--;
            Clear();
        }
    }
    public void Blacka()
    {
        b++;
        if (Black == 1)
        {
            a += Black;
            Black--;
            Clear();
        }
        else if (Black > 1)
        {
            a += 1;
            Black--;
            Clear();
        }
    }
    public void Purplea()
    {
        b++;
        if (Purple == 1)
        {
            a += Purple;
            Purple--;
            Clear();
        }
        else if (Purple > 1)
        {
            a += 1;
            Purple--;
            Clear();
        }
    }
}

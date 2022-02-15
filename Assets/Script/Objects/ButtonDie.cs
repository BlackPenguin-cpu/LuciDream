using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDie : MonoBehaviour
{
    Animator anim;
    int i = 0;
    public GameObject red;
    public GameObject gm;
    public GameObject Player2;
    void Start()
    {
        Player2.SetActive(false);
        anim = GetComponent<Animator>();
        red.SetActive(false);
        gm.SetActive(false);
    }
    public void ButtonOn()
    {
        i++;
        if(i > 0)
        {
            anim.SetBool("isButton", true);
            Invoke("aaa", 0.1f);
        }
    }

    void aaa()
    {
        i = 0;
        anim.SetBool("isButton", false);
        red.SetActive(true);
        Invoke("Red", 2);
        Invoke("Die", 2);
    }

    void Red()
    {
        red.SetActive(false);
    }

    void Die()
    {
        gm.SetActive(true);
        print("Á×À½");
    }
}

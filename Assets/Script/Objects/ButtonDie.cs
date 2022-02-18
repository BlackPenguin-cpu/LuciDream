using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDie : Objects
{
    Animator anim;
    int i = 0;
    public GameObject red;
    public GameObject gm;
    public GameObject MainCamera;
    protected override void Start()
    {
        anim = GetComponent<Animator>();
        red.SetActive(false);
        gm.SetActive(false);
    }
    public override void Interaction()
    {
        i++;
        if (i > 0)
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
        MainCamera.GetComponent<Inventory>().Button = true;
    }
}

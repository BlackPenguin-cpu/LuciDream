using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDie : MonoBehaviour
{
    Animator anim;
    int i = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
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
        print("Á×À½");
    }
}

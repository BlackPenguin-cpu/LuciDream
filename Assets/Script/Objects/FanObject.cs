using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanObject : Objects
{
    Animator anim;
    public override void Interaction()
    {
        GCP();
        base.Interaction();
        if (anim.GetBool("isTurning") == false)
        {
            anim.SetBool("isTurning", true);
        }
        else
        {
            anim.SetBool("isTurning", false);
        }
    }

    void GCP()
    {
        anim = GetComponent<Animator>();
    }
}


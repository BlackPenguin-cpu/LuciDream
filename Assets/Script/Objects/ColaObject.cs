using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaObject : Objects
{
    private Animator anim;
    public override void Interaction()
    {
        base.Interaction();
        anim = GetComponent<Animator>();
        anim.SetBool("isClick", true);
        Debug.Log("µðÁü ¤µ¤¡");
    }
}

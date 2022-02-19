using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaObject : Objects
{
    private Animator anim;
    public int number;
    public string text;
    public override void Interaction()
    {
        base.Interaction();
        anim = GetComponent<Animator>();
        anim.SetBool("isClick", true);
        Invoke(nameof(UION), 3f);
    }

    public void UION()
    {
        Invoke(nameof(die), 3f);
        Player.Instance._State = PlayerState.DIE;

    }
    void die()
    {
        DeathManager.Instance.OnDeathUI(number, text);
    }
}

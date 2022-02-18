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
        Invoke(nameof(Die), 3f);
    }

    public void Die()
    {
        DeathManager.Instance.OnDeathUI(number, text);

    }
}

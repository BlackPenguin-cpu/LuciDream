using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teemo : Objects
{
    public int number;
    public string text;
    public override void Interaction()
    {
        base.Interaction();
        Invoke(nameof(Die), 3f);
        Player.Instance._State = PlayerState.DIE;
    }

    void Die()
    {
        DeathManager.Instance.OnDeathUI(number, text);
    }
}

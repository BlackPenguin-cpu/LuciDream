using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmObject : Objects
{
    public Sprite um2;
    public int number;
    public string text;
    public override void Interaction()
    {
        base.Interaction();
        GetComponent<SpriteRenderer>().sprite = um2;
        Invoke(nameof(Die), 3f);
        Player.Instance._State = PlayerState.DIE;
    }
    
    void Die()
    {
        DeathManager.Instance.OnDeathUI(number, text);
    }
}

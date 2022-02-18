using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioCoin : MonoBehaviour
{
    public Animator anim;
    
    public void Coin()
    {
        anim.SetBool("isBouns", true);
    }

    public void trigger()
    {
        Player.Instance.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}

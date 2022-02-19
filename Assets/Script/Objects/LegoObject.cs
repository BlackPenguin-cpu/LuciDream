using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoObject : MonoBehaviour
{
    public int number;
    public string text;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke(nameof(die), 3f);
            Player.Instance._State = PlayerState.DIE;
        }
    }
    void die()
    {
            DeathManager.Instance.OnDeathUI(number, text);
    }
}

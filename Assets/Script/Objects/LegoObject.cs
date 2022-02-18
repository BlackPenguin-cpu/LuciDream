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
            //DeathManager.Instance.OnDeathUI(number, text);
        }
    }
}

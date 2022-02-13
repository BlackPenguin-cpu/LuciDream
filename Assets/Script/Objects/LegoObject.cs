using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoObject : MonoBehaviour
{
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
            Debug.Log("¿¿æ÷");
        }
    }
}

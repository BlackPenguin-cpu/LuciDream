using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("¤±¤¤¤·¤©!");
            other.gameObject.transform.Translate(new Vector3(1f, -1f, 0));
        }
    }
}

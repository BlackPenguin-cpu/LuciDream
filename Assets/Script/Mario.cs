using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mario : MonoBehaviour
{
    private Rigidbody2D rigid;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rigid = other.gameObject.GetComponent<Rigidbody2D>();
            Player.Instance.CoroutineQuit();
            rigid.constraints = RigidbodyConstraints2D.FreezePositionX;
            rigid.AddForce(new Vector3(0,5,0),ForceMode2D.Impulse);
            this.gameObject.SetActive(false);
        }
    }
}

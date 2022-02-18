using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mario : MonoBehaviour
{
    private Rigidbody2D rigid;
    private bool isdie = false;

    void Start()
    {
        Camera.main.transform.position = Vector3.zero;
        rigid = Player.Instance.gameObject.GetComponent<Rigidbody2D>();
        rigid.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rigid.bodyType = RigidbodyType2D.Dynamic;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && isdie == false)
        {
            Player.Instance.CoroutineQuit();
            rigid.constraints = RigidbodyConstraints2D.FreezePositionX;
            rigid.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
            isdie = true;
        }
        if (other.gameObject.tag == "Player" && isdie)
        {
            Debug.Log("난 디버그다");
            Player.Instance._State = PlayerState.DIE;
        }
    }
}

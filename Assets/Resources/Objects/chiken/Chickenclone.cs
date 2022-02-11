using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chickenclone : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    public int nextMove;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        Invoke("Think", 5);
    }
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);
        anim.SetBool("isChicken", true);
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);
        Invoke("Think", 5);
    }
}

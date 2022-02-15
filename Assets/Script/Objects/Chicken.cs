using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    public int nextMove;
    public GameObject chicken;
    public int a = 0;
    int i = 0;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        Invoke("Think", 1);        
    }
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);
        anim.SetBool("isChicken", true);
        Invoke("aaa", 0.5f);
    }

    void Think()
    {     
        nextMove = Random.Range(-2, 0);     
        Invoke("Think", 0.5f); 
        i++;
    }
    void aaa()
    {
        if(a < 20)
        {
            if (i > 0)
            {
                Instantiate(chicken);
                i = 0;
                a++;
            }
        }else
            print("Á×À½");
    }
}

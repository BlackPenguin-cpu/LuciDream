using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slander : MonoBehaviour
{
    
    Transform target;
    Rigidbody rb;
    Animator anim;

    public bool follow = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        if(follow == true)
        {
            anim.SetBool("isSlander", true);
            Invoke("Die", 4);
        }
        else
        {
            anim.SetBool("isSlander", false);
        }
    }

    void Die()
    {
        transform.position = target.position;
        print("Á×À½");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        follow = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        follow = false;
    }
}

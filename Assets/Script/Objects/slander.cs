using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slander : MonoBehaviour
{
    
    Transform target;
    Rigidbody rb;
    Animator anim;
    public GameObject Black;
    int a = 1;

    public bool follow = false;
    void Start()
    {
        Black.SetActive(false);
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
        if(a > 0)
        {
            Invoke("blackOn", 0.5f);
            Invoke("blackOff", 1.5f);
            print("Á×À½");
        }
    }

    void blackOff()
    {
        gameObject.SetActive(true);
        Black.SetActive(false);
        a = 0;
    }

    void blackOn()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 0.1f);
        gameObject.SetActive(false);
        Black.SetActive(true);
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

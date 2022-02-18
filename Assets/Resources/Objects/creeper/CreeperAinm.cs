using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreeperAinm : MonoBehaviour
{
    public GameObject mine;
    Animator anim;
    public float a;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        a += Time.deltaTime;
        if (a > 9)
        {
            anim.SetBool("isPang", true);
        }
        else
        {
            anim.SetBool("isPang", false);
        }
    }
}

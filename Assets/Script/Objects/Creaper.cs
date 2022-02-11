using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creaper : MonoBehaviour
{
    Animator anim;
    public GameObject creeper;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isPang", true);
        Invoke("aaa", 1.5f);
    }

    void aaa()
    {
        anim.SetBool("isPang", false);
        creeper.SetActive(false);
        print("Á×À½");
    }
}

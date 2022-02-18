using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chickenclone : MonoBehaviour
{
    Animator anim;
    public int nextMove;
    public GameObject game;


    private void Start()
    {
        anim = GetComponent<Animator>();
        Invoke("Think", 1);
    }
    void FixedUpdate()
    {
        //  SoundManager.Instance.PlaySound("Chickena");
        transform.position = Vector3.Lerp(transform.position, game.transform.position, Time.deltaTime);
        anim.SetBool("isChicken", true);
    }

    void Think()
    {
        nextMove = Random.Range(-2, 0);
        Invoke("Think", 2);
    }
}

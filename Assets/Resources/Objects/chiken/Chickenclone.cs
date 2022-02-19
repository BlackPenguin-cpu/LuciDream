using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chickenclone : MonoBehaviour
{
    Animator anim;
    public GameObject game;
    private void Start()
    {
        game = Player.Instance.gameObject;
       // GameObject.Find("Player").GetComponent<Transform>().transform.position = game.transform.position;
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //  SoundManager.Instance.PlaySound("Chickena");
        transform.position = Vector3.Lerp(transform.position, game.transform.position, Time.deltaTime *3 );
        anim.SetBool("isChicken", true);
    }
}

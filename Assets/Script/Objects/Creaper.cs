using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creaper : Objects
{
    Animator anim;
    public GameObject creeper;
    public string Name;
    public List<string> Speech;
    public AudioClip creaper;
    AudioSource audioSource;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void aaa()
    {
        anim.SetBool("isPang", false);
        creeper.SetActive(false);
        print("Á×À½");
    }
    public override void Interaction()
    {
        base.Interaction();
        StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
        anim.SetBool("isPang", true);
        audioSource.clip = creaper;
        Invoke("aaa", 1.5f);
    }
}

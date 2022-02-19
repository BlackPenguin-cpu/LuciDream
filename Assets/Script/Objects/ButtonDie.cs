using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDie : Objects
{
    Animator anim;
    int i = 0;
    public GameObject red;
    public GameObject gm;
    public GameObject blue;
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
        red.SetActive(false);
        gm.SetActive(false);
    }
    public override void Interaction()
    {
        i++;
        if (i > 0)
        {
            anim.SetBool("isButton", true);
            SoundManager.Instance.PlaySound("Beepa");
            Invoke("aaa", 0.1f);
        }
    }

    void aaa()
    {
        i = 0;
        blue.GetComponent<CameraWark>().VibrateDorTime(2);
        anim.SetBool("isButton", false);
        red.SetActive(true);
        Invoke("Red", 2);
        Invoke("Die", 4);
    }

    void Red()
    {
        gm.SetActive(true);
        SoundManager.Instance.PlaySound("Explosiona");
    }

    void Die()
    {
        DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[10]);
    }
}

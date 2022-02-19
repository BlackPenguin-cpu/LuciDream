using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potalgun : Objects
{
    public GameObject Image;
    public GameObject potal_bule;
    public GameObject potal_orange;

    protected override void Start()
    {
        base.Start();
        Image.SetActive(false);
        potal_bule.SetActive(false);
        potal_orange.SetActive(false);
    }
    public override void Interaction()
    {
        Image.SetActive(true);
    }

    public void yes()
    {
        SoundManager.Instance.PlaySound("Portalbutton");
        potal_bule.SetActive(true);
        potal_orange.SetActive(true);
        Image.SetActive(false);
    }

    public void no()
    {
        Image.SetActive(false);
    }
}

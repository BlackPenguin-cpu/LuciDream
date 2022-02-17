using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potalgun : Objects
{
    public GameObject MainCamera;
    public GameObject Image;
    public GameObject potal_bule;
    public GameObject potal_orange;

    private void Start()
    {
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
        potal_bule.SetActive(true);
        potal_orange.SetActive(true);
    }

    public void no()
    {
        Image.SetActive(false);
    }
}

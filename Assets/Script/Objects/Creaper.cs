using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creaper : MonoBehaviour
{
    Animator anim;
    public GameObject creeper;
    public GameObject black;
    public GameObject MainCamera;
    public float a;
    public bool b;
    void Start()
    {
        anim = GetComponent<Animator>();
        creeper.transform.position = new Vector3(0.96f, -1.42f, 5);
    }
    private void Update()
    {
        a += Time.deltaTime;
        bbb();
    }
    void aaa()
    {
        b = false;
        creeper.SetActive(false);
        MainCamera.GetComponent<Inventory>().Creeper = true;
    }

    void bbb()
    {
        if (a > 1)
        {
            black.SetActive(true);
        }
        if (a > 2)
        {
            black.SetActive(false);
        }
        if (a > 3)
        {
            black.SetActive(true);
        }
        if (a > 4)
        {
            creeper.transform.position = new Vector3(0.96f, -1.42f, -2.4f);
            black.SetActive(false);
        }
        if (a > 5)
        {
            creeper.transform.position = new Vector3(0.96f, -1.42f, 5);
            black.SetActive(true);
        }
        if (a > 6)
        {
            black.SetActive(false);
        }
        if(a > 7)
        {
            black.SetActive(true);
        }
        if(a > 8)
        {
            creeper.transform.position = new Vector3(0.96f, -1.42f, -2.4f);
            black.SetActive(false);
        }
        if(a > 9)
        {
            b = true;
            Invoke("aaa", 1.3f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeemoManager : MonoBehaviour
{
    public GameObject UI;
    public GameObject Teemo;
    void Start()
    {
        
    }

    void Update()
    {
        if (UI.GetComponent<ArrowKeyManager>().Clear)
        {
            Teemo.SetActive(true);
        }
    }
}

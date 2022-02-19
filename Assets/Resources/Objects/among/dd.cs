using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dd : MonoBehaviour
{
    public GameObject Amon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Amon.GetComponent<Among>().c == true)
        {
            CameraManager.Instance.Stop = false;
        }
    }
}

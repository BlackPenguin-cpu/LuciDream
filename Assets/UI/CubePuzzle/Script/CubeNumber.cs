using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeNumber : MonoBehaviour
{
    public GameObject Cube;
    public int Number = 0;
    public GameObject text;
    void Start()
    {
        
    }

    void Update()
    {
        if(Number == 5)
        {
            Number = 1;
        }
        text.GetComponent<Text>().text = Number.ToString(); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Memoryconterol : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        
    }


    void Update()
    {
        if(Canvas.GetComponent<Memory>().On == true)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }
}

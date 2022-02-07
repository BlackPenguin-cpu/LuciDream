using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentText : MonoBehaviour
{
    public Slider Bar;
    private float Value;
    void Start()
    {
        
    }

    void Update()
    {
        Value = Mathf.Round(Bar.value * 100);
        GetComponent<Text>().text = Value.ToString() + "%";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenTimer : MonoBehaviour
{
    public float LimitTime;
    public float Second;
    private Slider Timer;
    void Start()
    {
        Second = LimitTime;
        Timer = GetComponent<Slider>();
        Timer.maxValue = LimitTime;
    }

    void Update()
    {
        Timer.value = Second -= Time.deltaTime;
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public AudioSource Music;
    public Slider slider;
    public Text text;
    float Value = 0;
    int p = 0;
   
    public void Slider_right()
    {
        if (Value < 1)
        {
            Value += 0.1f;
            p += 10;
            
        }
        text.text = p.ToString() + "%";
        slider.GetComponent<Slider>().value = Value;
    }

    public void Slider_left()
    {
        if(Value > 0.1f)
        {
            Value -= 0.1f;
            p -= 10;
        }
        text.text = p.ToString() + "%";
        slider.GetComponent <Slider>().value = Value;
    }
}

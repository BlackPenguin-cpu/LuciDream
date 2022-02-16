using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Sprite image;
    public string text;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(asdf), 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void asdf()
    {

        DeathManager.Instance.OnDeathUI(number, image, text);
    }
}

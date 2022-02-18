using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Among : MonoBehaviour
{
    public GameObject bule;
    public GameObject red;
    public GameObject yellow;
    public float a = 0;
    public GameObject MainCamera;
    
    void Start()
    {
        bule.SetActive(false);
        red.SetActive(false);
        yellow.SetActive(false);
    }

    void Update()
    {
        a += Time.deltaTime;
        if(a > 2)
        {
            SoundManager.Instance.PlaySound("Amonga");
            bule.SetActive(true);
        }if(a > 3)
            SoundManager.Instance.PlaySound("Amonga");
        red.SetActive(true);
        if(a > 4)
        {
            SoundManager.Instance.PlaySound("Amonga");
            yellow.SetActive(true);
            MainCamera.GetComponent<Inventory>().among = true;
        }
    }
}

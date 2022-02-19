using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreddyMabb : MonoBehaviour
{
    public float a = 0;
    public GameObject Map2;
    public GameObject Freddy;
    public GameObject blue;
    public bool b = false;
    public bool c = false;
    void Start()
    {
        Map2.SetActive(false);
        Freddy.SetActive(false);
    }
    void Update()
    {
        a += Time.deltaTime;
        if(a > 2)
        {
            Map2.SetActive(true);
            if(a > 6)
            {
                Freddy.SetActive(true);
                if(b == false)
                {
                    Sound();
                }
                blue.GetComponent<CameraWark>().VibrateDorTime(2);
            }else if(a > 8)
            {
                if(c == false)
                {
                    Die();
                }
            }
        }
    }

    void Sound()
    {
        SoundManager.Instance.PlaySound("Freddy");
        b = true;
    }

    void Die()
    {
        DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[16]);
        c = true;
    }
}

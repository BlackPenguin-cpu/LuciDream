using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreddyMabb : MonoBehaviour
{
    public float a = 0;
    public GameObject Map2;
    public GameObject Freddy;
    public GameObject blue;
    void Start()
    {
        Map2.SetActive(false);
        Freddy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if(a > 2)
        {
            Map2.SetActive(true);
            if(a == 6)
            {
                Freddy.SetActive(true);
                SoundManager.Instance.PlaySound("Freddy");
            }else if(a > 8)
            {
                DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[16]);
            }
        }
    }
}

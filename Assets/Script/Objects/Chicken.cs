using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject chicken;
    public int a = 0;
    int i = 0;

    private void Awake()
    {
        Invoke("Think", 1);
    }
    void FixedUpdate()
    {
        Invoke("aaa", 0.5f);
    }

    void Think()
    {     
        Invoke("Think", 0.5f); 
        i++;
    }
    void aaa()
    {
        if(a < 20)
        {
            if (i > 0)
            {
                Instantiate(chicken);
                i = 0;
                a++;
            }
        }else
            DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[11]);
    }
}

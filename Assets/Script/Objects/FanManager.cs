using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanManager : MonoBehaviour
{
    public GameObject CloseDoorObject;
    public Animator Fan;
    private bool Check = true;
    void Start()
    {
        
    }

    void Update()
    {
        if (CloseDoorObject.GetComponent<CloseDoorObject>().State == 0 && Fan.GetBool("isTurning") && Check)
        {
            Check = false;
            Invoke(nameof(Die), 3f);

        }
    }

    void Die()
    {
        Debug.Log("¡Í±›!");
    }
}

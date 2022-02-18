using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanManager : MonoBehaviour
{
    public GameObject CloseDoorObject;
    public Animator Fan;
    public int number;
    public string text;
    private bool Check = false;
    private float time = 3;
    void Start()
    {

    }

    void Update()
    {
        if (CloseDoorObject.GetComponent<CloseDoorObject>().State == 0 && Fan.GetBool("isTurning"))
        {
            Check = true;
        }
        else
        {
            time = 3;
            Check = false;
        }
        if (time <= 0)
        {
            Die();
        }
        if (Check)
        {
            time -= Time.deltaTime;
        }
    }

    void Die()
    {
        Debug.Log("Áê±Ý!");
        DeathManager.Instance.OnDeathUI(number, text);
    }
}

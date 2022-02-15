using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWark : MonoBehaviour
{
    public float ShakeAmount;
    float Shaketime;
    Vector3 initialPosition;

    public void VibrateDorTime(float time)
    {
        Shaketime = time;
    }
    void Start()
    {
        initialPosition = new Vector3(0, 0, -5);
    }

    void Update()
    {
        if (Shaketime > 0)
        {
            transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition;
            Shaketime -= Time.deltaTime;
        }
        else
        {
            Shaketime = 0;
            transform.position = initialPosition;
        }
    }
}

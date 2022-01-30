using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotation : MonoBehaviour
{
    public List<GameObject> Cube;
    void Start()
    {
        Debug.Log(Cube[0].transform.rotation.z);
        Debug.Log(Cube[1].transform.rotation.z);
        Debug.Log(Cube[2].transform.rotation.z);
    }

    void Update()
    {
        if (Cube[0].transform.rotation.z == Cube[1].transform.rotation.z && Cube[1].transform.rotation.z == Cube[2].transform.rotation.z)
        {
            Debug.Log("¿¿æ÷..");
        }
    }

    public void Rotation(int CubeNumber)
    {
        Vector3 RightRotation = new Vector3(0, 0, -90);
        for (int i = CubeNumber; i <= CubeNumber + 1; i++)
        {
            if (i == 3)
            {
                Cube[0].transform.Rotate(RightRotation);
            }
            else
            {
                Cube[i].transform.Rotate(RightRotation);
            }
        }
    }
}

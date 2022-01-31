using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotation : MonoBehaviour
{
    public List<GameObject> Cube;
    public List<int> Number;
    public int Max;
    void Start()
    {
    }

    void Update()
    {
        Count();
        if (Number[0] == Number[1] && Number[1] == Number[2])
        {
            Debug.Log("±ô¹ÙÆØº¸");
        }
    }

    public void Rotation(int CubeNumber)
    {
        Vector3 RightRotation = new Vector3(0, 0, -90);
        for (int i = CubeNumber; i <= CubeNumber + 1; i++)
        {
            if (i == Max)
            {
                Cube[0].transform.Rotate(RightRotation);
                Cube[0].GetComponent<CubeNumber>().Number++;
            }
            else
            {
                Cube[i].transform.Rotate(RightRotation);
                Cube[i].GetComponent<CubeNumber>().Number++;
            }
        }
    }

    void Count()
    {
        for (int i = 0; i < 3; i++)
        {
            Number[i] = Cube[i].GetComponent<CubeNumber>().Number;
        }

    }
    public void asdf(int[] a)
    {
        Debug.Log("asdf");
    }

}

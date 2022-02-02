using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public List<GameObject> Cubes;
    public List<int> Numbers;
    void Start()
    {
    }

    void Update()
    {
        Count();
        Check();
    }

    void Check()
    {
        if (Numbers[0] == Numbers[1] && Numbers[1] == Numbers[2])
        {
            Debug.Log("±ô¹ÙÆØº¸");
        }
    }

    void Count()
    {
        for (int i = 0; i < 3; i++)
        {
            Numbers[i] = Cubes[i].GetComponent<Cube>().Number;
        }
    }
}

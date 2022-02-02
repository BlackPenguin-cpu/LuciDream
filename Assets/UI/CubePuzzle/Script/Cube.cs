using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public int Number = 0;
    public GameObject text;
    public List<GameObject> Cubes;
    void Start()
    {

    }

    void Update()
    {
        if (Number == 5)
        {
            Number = 1;
        }
        text.GetComponent<Text>().text = Number.ToString();
    }

    public void Rotation()
    {
        Vector3 RightRotation = new Vector3(0, 0, -90);
        for(int i = 0; i < Cubes.Count; i++)
        {
            Cubes[i].transform.Rotate(RightRotation);
            Cubes[i].GetComponent<Cube>().Number++;
        }
    }


}

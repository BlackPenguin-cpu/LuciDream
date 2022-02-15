using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creeeeeeeeper : MonoBehaviour
{
    Vector3 target = new Vector3(5.51f, 13.96f, 0);
    Vector3 no = new Vector3(5.53f, 13.05f, 0);
    public GameObject gm;
    private void Start()
    {
        gm.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.SetActive(true);
        }
    }
}

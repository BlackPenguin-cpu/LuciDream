using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creeeeeeeeper : MonoBehaviour
{
    Vector3 target = new Vector3(5.51f, 13.96f, 0);
    Vector3 no = new Vector3(5.53f, 13.05f, 0);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = Vector3.MoveTowards(no, target, 0.1f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.position = Vector3.MoveTowards(target, no, 0.1f);
    }
}

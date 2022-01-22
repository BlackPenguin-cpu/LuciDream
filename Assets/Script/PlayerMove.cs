using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 10f;
    Vector3 mousePos, transPos, targetPos;
    bool isHorizontal = true;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            CalTargetPos();
        }
    }
    private Vector2 tpos2d;
    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        print(collision.collider.name);
    }
}

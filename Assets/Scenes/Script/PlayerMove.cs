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

    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);

    }

    void FixedUpdate()
    {
       // Vector3 targetPos = isHorizontal ? new Vector3(transPos.x, 0) : new Vector3(0, transPos.y);
      
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }
}

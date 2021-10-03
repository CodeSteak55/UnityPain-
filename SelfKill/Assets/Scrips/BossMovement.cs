using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    private float speed;
    private bool moveRight

    void Start()
    {
        speed = 2f;
        moveRight = true;
        
    }

    void Update()
    {
        if (tranform.position.x > 6f)
        {
            moveRight = false; 
        }
        else if (tranform.position.x > -6f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            tranform.position = new Vector 2(transform.position.x + speed * Time.deltaTime
                tranform.position.y);
        }
        else
        {
            tranform.position = new Vector 2(transform.position.x + speed * Time.deltaTime
                tranform.position.y);
        }
    }
}
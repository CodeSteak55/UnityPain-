using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float Speed;
    private vector2 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        movespeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltatime);
    }

    public void SetMoveDirection(vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetArchive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}

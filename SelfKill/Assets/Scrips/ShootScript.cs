using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    [SerializeField]
    private int bulletAmount = 10;

    [SerializeField]
    private float startAngle = 90f, endAngle = 270;

    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);
    }

    private void fire()
    {
        float angleStep = (endAngle - startAngle) / bulletAmount
        float angle = startAngle 

        for (int i = 0; i < bulletAmount + 1; 1++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f)
            Vector2 bulDir = (bulMoveVector - transfrom.position).normalized;

            gameObject bul = BulletPool.bulletPoolInstance.GetBullet();
                bul.transform.position = tranform.position;
                bul.transform.rotation = tranform.rotation;
                bul.SetActive(true);
                bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;


        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController2 : MonoBehaviour
{
    public float speed;
    private float time = 0;
  
    void Update()
    {
        moveBullet();
    }
    void moveBullet()
    {
        if (time == 30000)
        {
            Destroy(this.gameObject);
        }
        time++;
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
}

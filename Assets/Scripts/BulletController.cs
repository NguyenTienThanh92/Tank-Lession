using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    private float time = 0;



    void Update()
    {
        bulletController();
    }
    void bulletController()
    {
        if (time == 80000)
        {
            Destroy(this.gameObject);
        }
        time++;
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
}
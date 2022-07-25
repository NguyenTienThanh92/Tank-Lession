using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    private float time = 0;
    public GameObject smoke;



    void Update()
    {
        moveBullet();
    }
    void moveBullet()
    {
        if (time == 200)
        {
            Destroy(this.gameObject);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        time++;
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
    
}

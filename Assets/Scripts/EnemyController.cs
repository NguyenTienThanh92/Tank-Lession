using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speed;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject transhoot1;
    public GameObject transhoot2;
    public GameObject bodytank;
    public GameObject Player;

    void Update()
    {
        Vector3 direction = Player.transform.position;
        var gunDirection = direction - transform.position;

        if (gunDirection != Vector3.zero)
        {
            this.gameObject.transform.up = gunDirection;
        }
        this.gameObject.transform.position += gunDirection * Time.deltaTime * speed;

        gun1.transform.up = gunDirection;

        if (Random.Range(0,100) % 50 == 0)
        {
            Instantiate(bullet1, transhoot1.transform.position, transhoot1.transform.rotation);
        }
     

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "playerbullet")
        {
            Debug.Log("No Enemy");
            Destroy(gameObject);
        }
    }
}

        
        
    

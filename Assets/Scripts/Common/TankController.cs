using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MoveController
{
    public Transform bodyTank;
    public Transform gun;
    public GameObject bullet;
    public Transform transhoot;
    public string trigger1;
    public string trigger2;
    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            bodyTank.up = direction;
        }
        base.Move(direction);  
    }
    protected void RotateGun(Vector3 direction)
    {
         gun.up = direction;
    }
    public void Shoot()
    {
        Instantiate(bullet, transhoot.position, transhoot.rotation);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == trigger1)
        {
            Destroy(gameObject);
            GameManager.instance.addScore();
        }
        if (collision.gameObject.tag == trigger2)
        {
           // Destroy(gameObject);
        }
    }
        
}

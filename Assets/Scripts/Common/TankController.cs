using UnityEngine;

public class TankController : MoveController
{
    public Transform bodyTank;
    public Transform gun;
    public BulletController bullet;
    public Transform transhoot;
    public float hp;
    public float level;
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
        if (collision.gameObject.tag != this.gameObject.tag)
        {
            hp = bullet.CalculateHp(hp, level);
            Debug.Log("bi ban trigger1");
        }
        ////if (collision.gameObject.tag == trigger2)
        ////{
        ////    hp = bullet.CalculateHp(hp, level);
        ////    Debug.Log("bi ban trigger2");
        //}
    }
        
}

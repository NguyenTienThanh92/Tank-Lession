using UnityEngine;

public class TankController : MoveController
{
    public Transform bodyTank;
    public Transform gun1;
    public Transform gun2;
    public BulletController bullet1;
    public BulletController bullet2;
    public Transform transhoot1;
    public Transform transhoot2;
    public string trigger1;
    public string trigger2;
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
         gun1.up = direction;
         gun2.up = direction;
    }
    public void Shoot()
    {
        Instantiate(bullet1, transhoot1.position, transhoot1.rotation);
        Instantiate(bullet2, transhoot2.position, transhoot2.rotation);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == trigger1)
        {
            hp = bullet1.CalculateHp(hp, level);
            hp = bullet2.CalculateHp(hp, level);
        }
        if (collision.gameObject.tag == trigger2)
        {
            hp = bullet1.CalculateHp(hp, level);
            hp = bullet2.CalculateHp(hp, level);
        }
    }
        
}

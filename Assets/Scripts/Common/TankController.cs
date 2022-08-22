using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

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
    protected virtual void Shoot()
    {
        CreatBullet(transhoot);
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != this.gameObject.tag)
        {
            var calculateHP = collision.GetComponent<BulletController>();
            if (calculateHP is null)
            {
                return;
            }
            hp = calculateHP.CalculateHp(hp);
        }
       
    }
    public BulletController CreatBullet (Transform tranShoot)
    {
        BulletController bulletclone = PoolingObject.createPooling<BulletController>(bullet);
        if (bulletclone == null)
        {
            return Instantiate(bullet, tranShoot.position, tranShoot.rotation);
        }
        bulletclone.time = 0;
        bulletclone.transform.position = tranShoot.position;
        bulletclone.transform.rotation = tranShoot.rotation;
        bulletclone.damage += level;
        bulletclone.tag = this.tag;
        return bulletclone;
    }
        
}

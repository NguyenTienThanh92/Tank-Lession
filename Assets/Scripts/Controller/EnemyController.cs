using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class EnemyController : TankController
{
    void Update()
    {
        var player  = Player.Instance.gameObject.transform;
        Vector3 direction = player.position;
        var gunDirection = direction - transform.position;

        Move(gunDirection);
        RotateGun(gunDirection);

        if (Random.Range(0,100) % 80 == 0)
        {
            Shoot();
        }

        if (hp <= 0)
        {
            Destroy(this.gameObject);
            Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY, level);
        }
    }   
}

        
        
    

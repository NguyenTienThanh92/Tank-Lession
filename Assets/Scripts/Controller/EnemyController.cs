using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class EnemyController : TankController
{
    void Update()
    {
        var player1  = Playerlv1.Instance.gameObject.transform;
       // var player2  = Playerlv2.Instance.gameObject.transform;
        Vector3 direction = player1.position;
        //Vector3 direction = player2.position;
        var gunDirection = direction - transform.position;

        Move(gunDirection);
        RotateGun(gunDirection);

        if (Random.Range(0,100) % 70 == 0)
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

        
        
    

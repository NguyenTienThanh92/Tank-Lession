using UnityEngine;

public class EnemyController : TankController
{
    void Update()
    {
        var player  = PlayerController.instance.gameObject.transform;
        Vector3 direction = player.position;
        var gunDirection = direction - transform.position;

        Move(gunDirection);
        RotateGun(gunDirection);

        if (Random.Range(0,100) % 50 == 0)
        {
            Shoot();
        }
    }   
}

        
        
    

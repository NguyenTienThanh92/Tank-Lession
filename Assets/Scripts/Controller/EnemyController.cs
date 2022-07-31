using System.Collections;
using System.Collections.Generic;
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

        if (Random.Range(0,100) % 60 == 0)
        {
            Shoot();
        }
    }   
}

        
        
    

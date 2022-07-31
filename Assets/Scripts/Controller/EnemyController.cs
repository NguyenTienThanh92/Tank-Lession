using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : TankController
{
    
    public GameObject Player;

    void Update()
    {
        Vector3 direction = Player.transform.position;
        var gunDirection = direction - transform.position;

        Move(gunDirection);
        RotateGun(gunDirection);

        if (Random.Range(0,100) % 1 == 0)
        {
            Shoot();
        }
    }   
}

        
        
    

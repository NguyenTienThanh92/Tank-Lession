using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyController : BulletController
{ 
    void Update()
    {
        bulletEx();
        Move(this.transform.up);
    }
    public override float CalculateHp(float hp, float level)
    {
        var hpLeft = hp - (level + damage);
        return hpLeft;

    }
}

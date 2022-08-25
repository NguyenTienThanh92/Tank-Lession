using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerIce : BulletController, IceSkill
{
    public GameObject prebIce;
    public void EffIceBounding(GameObject oppoment)
    {
        var affected = oppoment.GetComponent<MoveController>();
        if (affected is null)
        {
            return;
        }
        affected.speed = 0;
    }

    public float Ice(int dameff)
    {
        Instantiate(prebIce, this.gameObject.transform.position, this.gameObject.transform.rotation);
        return dameff;
    }

    protected override void bulletEx()
    {
        if ( time == 30)
        {
            Instantiate(prebIce, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Debug.Log("bang dau???");
        }
        base.bulletEx();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Enemy")
        {
            damage += Ice(25);
            EffIceBounding(collision.gameObject);
        }
    }
}

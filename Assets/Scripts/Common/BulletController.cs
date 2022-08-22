using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController
{
    public float time = 0;
    public GameObject smoke;
    public float timeLimit;
    public float damage;


    void Update()
    {
        bulletEx();
        Move(this.transform.up);
    }
    
    protected virtual void bulletEx()
    {
        if (time == timeLimit)
        {
            PoolingObject.DestroyPooling<BulletController>(this);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        time++;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
    public virtual float CalculateHp(float hp)
    {
        var hpLeft = hp  - damage;
        return hpLeft;
    }
}

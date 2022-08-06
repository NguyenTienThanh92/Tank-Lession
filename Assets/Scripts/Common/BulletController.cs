using UnityEngine;

public class BulletController : MoveController
{
    private float time = 0;
    public GameObject smoke;
    public float timeLimit;
    public float damage;


    void Update()
    {
       
    }
    
    protected virtual void bulletEx()
    {
        if (time == timeLimit)
        {
            Destroy(this.gameObject);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        time++;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
    public virtual float CalculateHp(float hp, float level)
    {
        var hpLeft = hp - (level + damage);
        Debug.LogError(level + damage);
        return hpLeft;
    }
}

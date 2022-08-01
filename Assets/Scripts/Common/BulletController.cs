using UnityEngine;

public class BulletController : MoveController
{
    private float time = 0;
    public GameObject smoke;
    public float timeLimit;


    void Update()
    {
        bulletEx();
        Move(this.transform.up);
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
}

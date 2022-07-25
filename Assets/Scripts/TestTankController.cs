using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTankController : MonoBehaviour
{
    public int speed;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject transhoot1;
    public GameObject transhoot2;
    public GameObject bodytank;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        tankMove();
        gunRotation();
        gunShoot();
    }
    private void tankMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        

        if (direction != Vector3.zero)
        {
            this.gameObject.transform.up = direction;
        }
        this.gameObject.transform.position += direction * Time.deltaTime * speed;

        
    }
    private void gunRotation()
    {
        Vector3 gunDirection = new Vector3(
            Input.mousePosition.x - Screen.width / 2,
            Input.mousePosition.y - Screen.height / 2);
        gun1.transform.up = gunDirection;
        gun2.transform.up = gunDirection;
    }
    void gunShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet1, transhoot1.transform.position, transhoot1.transform.rotation);
            Instantiate(bullet2, transhoot2.transform.position, transhoot2.transform.rotation);
        }
    }
    

}

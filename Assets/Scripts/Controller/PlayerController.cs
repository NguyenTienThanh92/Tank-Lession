using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : TankController 
{
    public static PlayerController instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);

        Move(direction);

        var position = Input.mousePosition;
        Vector3 gunDirectionmoba = new Vector3(
            position.x - Screen.width / 2,
            position.y - Screen.height / 2);

        RotateGun(gunDirectionmoba);
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}

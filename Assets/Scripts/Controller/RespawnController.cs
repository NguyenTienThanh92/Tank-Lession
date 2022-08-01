using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public static RespawnController instance;
    public GameObject gate;
    public GameObject enemy;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var Tank = PlayerController.instance.gameObject.transform;
        //Transform gate = Tank.transform;
        //Vector3 newPos = new Vector3(gate.position.x, gate.position.y);
        //transform.position = Vector3.Lerp(transform.position, newPos, 20f);
    }
    public void  respawn()
    {
        Instantiate(enemy, gate.transform.position, gate.transform.rotation);
    }
}

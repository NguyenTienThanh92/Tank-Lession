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
        
    }
    public void  Respawn()
    {
        Instantiate(enemy, gate.transform.position, gate.transform.rotation);
    }
}

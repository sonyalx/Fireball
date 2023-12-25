using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public float speed = 2f;


     void Start()
    {
        Destroy(gameObject, 3);
    }
    
    void Update()
    {        

        transform.position += transform.forward * speed * Time.deltaTime;
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        Destroy(other.gameObject);
    }
}

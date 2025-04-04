using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fencedie : MonoBehaviour
{
    float health = 1000;

    void Update()
    {
        Die();
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Crow")
        {
            health -=1;
        }
    }

    void Die()
    {
        if (health <= 0)
        {
            transform.position = new Vector3(0,-10,0);
        } 
    }
}

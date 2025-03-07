using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fencedie : MonoBehaviour
{
    static float health = 1000;
    public bool isAlive = true;

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
            Destroy(gameObject);
            isAlive = false;
        } 
    }
}

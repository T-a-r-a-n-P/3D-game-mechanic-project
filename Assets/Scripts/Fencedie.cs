using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Fencedie : MonoBehaviour
{
    public float health = 1000;
    public bool alive = true;
    

   void start()
   {

   }
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
        if (health <= 0 && alive == true)
        {
            transform.position += new UnityEngine.Vector3(0f,-10f,0f);
            alive = false;
        } 
    }

}

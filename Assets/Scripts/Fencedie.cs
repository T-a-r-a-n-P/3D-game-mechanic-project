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
   // public GameObject repaircheck;
    //public GameObject repaircheckTransform;
    //public FenceRepair repairdafence;

   void start()
   {
       // repairdafence = GameObject.FindObjectOfType<FenceRepair> ();
   }
    void Update()
    {
        Die();
        // if(repairdafence.repair == true)
        // {
        //     transform.position = repaircheckTransform.transform.position;
        // }
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

    void createChecker()
    {
       // GameObject collisionchecker = Instantiate(repaircheck, repaircheckTransform.transform.position, repaircheckTransform.transform.rotation);
    }
}

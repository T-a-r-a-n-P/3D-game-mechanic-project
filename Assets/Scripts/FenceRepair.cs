using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceRepair : MonoBehaviour
{
    public getLogFromTree logholding;
    public Fencedie deadfence;

    void Update()
    {
        logholding = GameObject.Find("log_1a (1)").GetComponent<getLogFromTree> ();
        deadfence = GameObject.FindObjectOfType<Fencedie> ();
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && logholding.holdinglog == true && deadfence.alive == false)
        {
            Debug.Log("nnnnnnnn");
            transform.position += new UnityEngine.Vector3(0f,10f,0f);
            logholding.loginhand.SetActive(false);
            logholding.holdinglog = false;
        }
    }
}

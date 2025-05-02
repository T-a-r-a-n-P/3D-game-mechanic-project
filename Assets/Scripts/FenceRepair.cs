using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceRepair : MonoBehaviour
{
    public getLogFromTree logholding;
    public logholder x;
    public Fencedie deadfence;
    public GameObject Fence;
    public bool repair = false;

    void Update()
    {
        x = GameObject.FindObjectOfType<logholder> ();
        logholding = GameObject.FindObjectOfType<getLogFromTree> ();
        deadfence = GameObject.FindObjectOfType<Fencedie> ();
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && x.active == true)
        {
            Fence.SetActive(true);
            logholding.loginhand.SetActive(false);
            logholding.holdinglog = false;
        }
    }


}

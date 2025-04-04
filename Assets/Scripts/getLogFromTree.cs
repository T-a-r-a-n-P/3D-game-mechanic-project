using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getLogFromTree : MonoBehaviour
{
    public GameObject pickuptext;
    public GameObject loginhand;
    public bool holdinglog = false;
    void Start()
    {
        pickuptext.SetActive(false);
        loginhand.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickuptext.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                holdinglog = true;
                loginhand.SetActive(true);
                deactivate();
            }
        }
    }
    void deactivate()
    {
        this.gameObject.SetActive(false);
    }
}

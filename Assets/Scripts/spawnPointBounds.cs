using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnPointBounds : MonoBehaviour
{
    public GameObject enmysporner;
    public GameObject spawnpoint;
    public GameObject timer;
    public bool inlevel = false;
    void Start()
    {
        enmysporner.SetActive(false);
        timer.SetActive(false);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SpawnPointBounds")
        {
            inlevel = true;
            transform.position = spawnpoint.transform.position;
            enmysporner.SetActive(true);
            timer.SetActive(true);
        }
    }
}

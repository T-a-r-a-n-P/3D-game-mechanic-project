using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnPointBounds : MonoBehaviour
{
    public GameObject enmysporner;
    public GameObject spawnpoint;
    void Start()
    {
        enmysporner.SetActive(false);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SpawnPointBounds")
        {
            transform.position = spawnpoint.transform.position;
            enmysporner.SetActive(true);
        }
    }
}

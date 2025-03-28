using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemymovement : MonoBehaviour
{
    public List<GameObject> targets;
    public Transform target;
    public Animator animtor;
    public float speed;
    public bool isntAttacking;
    public int arraylength;
    public int num;
    public CropsDie deadcrops;


    public void Start()
    {
        animtor = gameObject.GetComponent<Animator>();
        System.Random rng = new System.Random(); 
        FindTaggedObjects();

        num = rng.Next(targets.Count);
        target = targets[num].transform;

        deadcrops = target.GetComponent<CropsDie>();
    }

    void FindTaggedObjects()
    {
        GameObject[] taggedArray = GameObject.FindGameObjectsWithTag("Crops");
        targets = taggedArray.ToList();
    }
    private void Update()
    {
        cropsdead();
        transform.LookAt(target.position);
        if(isntAttacking)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if(other.gameObject.tag == "Fence")
        {
            animtor.enabled = true;
            isntAttacking = false;
        }
        if(distance < 1.35)
        {
            animtor.enabled = true;
            isntAttacking = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if(other.gameObject.tag == "Fence")
        {
            animtor.enabled = false;
            isntAttacking = true;
        }
        if(distance < 1.35)
        {
            animtor.enabled = false;
            isntAttacking = true;
        }
    }
    void cropsdead()
    {
        if (deadcrops.health <= 0) 
        {
            animtor.enabled = false;
            isntAttacking = true;
            System.Random rng = new System.Random(); 
            num = rng.Next(targets.Count);
            target = targets[num].transform;
            
            deadcrops = target.GetComponent<CropsDie>();
            
        }
    }
}

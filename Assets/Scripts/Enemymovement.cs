using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public Transform target;
    public AnimationClip anim;
    public Animator animtor;
    public float speed;
    public bool isntAttacking;

    public void Start()
    {
        animtor = gameObject.GetComponent<Animator>();
    }
    private void Update()
    {
        transform.LookAt(target.position);
        if(isntAttacking)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Fence")
        {
            animtor.enabled = true;
            isntAttacking = false;
            //anim.Play();
        }
    }
}

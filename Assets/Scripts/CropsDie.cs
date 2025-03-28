using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CropsDie : MonoBehaviour
{
    public float health = 500;
    void Update()
    {
        Die();
    }

    void Die()
    {
        if (health <= 0)
        {
            transform.position = new Vector3(0,-10,0);
            gameObject.tag = "Untagged";
        } 
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Crow")
        {
            health -=1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject WeaponOnFloor;
    public PickUp peckap;
    void Start()
    {
        peckap = GameObject.FindObjectOfType<PickUp> ();
    }
    public void Dropping()
    {
         if (Input.GetKey(KeyCode.G))
         {
            Debug.Log("dropping weapon...");
            this.gameObject.SetActive(false);
            WeaponOnFloor.SetActive(true);
            peckap.holding = false;
        }
    }
    
    void Update()
    {
        Dropping();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject WeaponOnFloor;
    public GameObject playerholder;

    public FirstPersonMovement holdingbool;    
    void Start()
    {
        playerholder = GameObject.Find("Player");
        holdingbool = GameObject.FindObjectOfType<FirstPersonMovement>();
    }
    public void Dropping()
    {
         if (Input.GetKey(KeyCode.G))
         {
            Debug.Log("dropping weapon...");
            this.gameObject.SetActive(false);
            WeaponOnFloor.SetActive(true);
            holdingbool.Holding = false;
        }
    }
    
    void Update()
    {
        Dropping();
    }
}

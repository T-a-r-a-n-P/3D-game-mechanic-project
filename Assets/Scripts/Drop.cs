using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject WeaponOnFloor;
    public void Dropping()
    {
         if (Input.GetKey(KeyCode.G))
         {
            Debug.Log("dropping weapon...");
            this.gameObject.SetActive(false);
            WeaponOnFloor.SetActive(true);
        }
    }
    
    void Update()
    {
        Dropping();
    }
}

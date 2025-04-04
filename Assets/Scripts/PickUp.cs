using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject WeaponOnPlayer;
    public GameObject PickUpText;
    public FirstPersonMovement holdingbool;

    void Start()
    {
        WeaponOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
        holdingbool = GameObject.FindObjectOfType<FirstPersonMovement> ();
    }
    public void OnTriggerStay(Collider other)
    {
        if(holdingbool.Holding == false)
        {
          if (other.gameObject.tag == "Player")
            {
                PickUpText.SetActive(true);
                
                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);
                    WeaponOnPlayer.SetActive(true);
                    PickUpText.SetActive(false);
                    holdingbool.Holding = true;
                }
            }
        }
        
    }
    

    public void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}

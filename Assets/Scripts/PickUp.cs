using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject WeaponOnPlayer;
    public GameObject PickUpText;

    void Start()
    {
        WeaponOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    void Update()
    {
    
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            {
                PickUpText.SetActive(true);
                
                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);
                    WeaponOnPlayer.SetActive(true);
                    PickUpText.SetActive(false);
                }
            }
        
    }
    

    public void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}

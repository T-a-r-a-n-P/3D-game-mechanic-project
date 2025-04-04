using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject WeaponOnPlayer;
    public GameObject PickUpText;
    public bool holding = false;

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
        if(holding == false)
        {
          if (other.gameObject.tag == "Player")
            {
                PickUpText.SetActive(true);
                
                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);
                    WeaponOnPlayer.SetActive(true);
                    PickUpText.SetActive(false);
                    holding = true;
                }
            }
        }
        
    }
    

    public void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}

using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject WeaponOnPlayer;
    public GameObject PickUpText;
    public bool IsPickedUp;

    void Start()
    {
        WeaponOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
        IsPickedUp = false;
    }

    void Update()
    {
        if (IsPickedUp == true)
        {
            Drop();
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (IsPickedUp == false)
        {
            if (other.gameObject.tag == "Player")
            {
                PickUpText.SetActive(true);
                
                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);
                    WeaponOnPlayer.SetActive(true);
                    PickUpText.SetActive(false);
                    IsPickedUp = true;
                }
            }
        }
    }
    public void Drop()
    {
        {
            if (Input.GetKey(KeyCode.G))
            {
                this.gameObject.SetActive(true);
                WeaponOnPlayer.SetActive(false);
                IsPickedUp = false;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}

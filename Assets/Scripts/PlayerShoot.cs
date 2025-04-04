using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public float bulletSpeed;
    public float fireRate, bulletDamage;
    public bool isAuto;
    public bool oneUse;

    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;
    private float timer;
    public FirstPersonMovement holdingbool; 

    void Start()
    {
        holdingbool = GameObject.FindObjectOfType<FirstPersonMovement> ();
    }
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime / fireRate;
        }
        if (isAuto)
        {
            if (Input.GetButton("Fire1")&& timer <= 0)
            {
                Shoot();
                if(oneUse)
                {
                    deactivate();
                    gameObject.SetActive(false);
                }
            }
        }
        else
        {
            if(Input.GetButtonDown("Fire1") && timer <= 0)
            {
                Shoot();
                if(oneUse)
                {
                    deactivate();
                    gameObject.SetActive(false);
                }
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnTransform.forward * bulletSpeed, ForceMode.Impulse);
        bullet.GetComponent<BulletController>().damage = bulletDamage;

        timer = 1;
    }
    void deactivate()
    {
        holdingbool.Holding = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float bulletSpeed;
    public float fireRate, bulletDamage;
    public bool isAuto;

    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;
    private float timer;

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
            }
        }
        else
        {
            if(Input.GetButtonDown("Fire1") && timer <= 0)
            {
                Shoot();
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
}

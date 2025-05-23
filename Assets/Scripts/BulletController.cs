using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float damage;
    public float lifeTime;
    public bool despawnOnCollision;

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime < 0 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyHealthManager>() != null)
        {
            other.GetComponent<EnemyHealthManager>().Health -= damage;
        }
        Destroy(gameObject);
    }
}

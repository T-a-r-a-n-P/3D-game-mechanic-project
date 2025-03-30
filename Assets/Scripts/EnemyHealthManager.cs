using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public float Health;
    public EnemySpawner enemySpawner;

    void Start()
    {
        enemySpawner = GameObject.FindObjectOfType<EnemySpawner> ();
    }

    private void Update()
    {
        if (Health <=0 )
        {
            Destroy(gameObject);
            enemySpawner.enemiesAlive -=1;
        }
    }
}

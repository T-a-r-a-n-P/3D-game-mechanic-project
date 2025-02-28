using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public float Health;

    private void Update()
    {
        if (Health <=0 )
        {
            Destroy(gameObject);
        }
    }
}

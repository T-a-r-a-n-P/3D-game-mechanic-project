using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_manager : MonoBehaviour
{
    public Slider healthBar;
    public int maxHealth;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;

        if (Input.GetKeyDown(KeyCode.V))
        {
            health -= 10;
        }
    }
}

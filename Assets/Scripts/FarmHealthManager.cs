using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FarmHealthManager : MonoBehaviour
{
    public List<GameObject> targets;
    public Slider slider;
    public GameObject gameoverscreen;

    public int currenthealth = 64;
    void Start()
    {
        Time.timeScale = 1f;
        FindTaggedObjects();
        slider.maxValue = 64;
    }
    void Update()
    {
        currenthealth = targets.Count;
        FindTaggedObjects();
        slider.value = currenthealth;
        Die();
    }
    void FindTaggedObjects()
    {
        GameObject[] taggedArray = GameObject.FindGameObjectsWithTag("Crops");
        targets = taggedArray.ToList();
    }
    void Die()
    {
        if (currenthealth == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            gameoverscreen.SetActive(true);
        }
    }
}

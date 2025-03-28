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

    public int currenthealth;
    void start()
    {
        FindTaggedObjects();
        slider.maxValue = 64;
    }
    void Update()
    {
        currenthealth = targets.Count;
        FindTaggedObjects();
        slider.value = currenthealth;
    }
    void FindTaggedObjects()
    {
        GameObject[] taggedArray = GameObject.FindGameObjectsWithTag("Crops");
        targets = taggedArray.ToList();
    }
    void Die()
    {
        if (slider.value == 0)
        {
            Time.timeScale = 0f;
            gameoverscreen.SetActive(true);
        }
    }
}

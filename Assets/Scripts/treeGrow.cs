using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class treeGrow : MonoBehaviour
{
    public GameObject growText;
    public GameObject crop;
    public GameObject plant;
    public GameObject tree;
    void Start()
    {
        growText.SetActive(false);
        crop.SetActive(false);
        plant.SetActive(false);
        tree.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            growText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                crop.SetActive(true);
                StartCoroutine(growPlant());
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            growText.SetActive(false);
        }
    }
    public IEnumerator growPlant()
    {
        yield return new WaitForSeconds(2);
        crop.SetActive(false);
        plant.SetActive(true);
        StartCoroutine(growTree());
    }
    public IEnumerator growTree()
    {
        yield return new WaitForSeconds(2);
        plant.SetActive(false);
        tree.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopkeeper : MonoBehaviour
{
    [SerializeField]
    GameObject[] UIElements;

    [SerializeField]
    Text description;

    [SerializeField]
    GameObject Items;

    //Need to be fixed
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            for (int i = 0; i < UIElements.Length; i++)
            {
                UIElements[i].SetActive(true);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        for (int i = 0; i < UIElements.Length; i++)
        {
            UIElements[i].SetActive(false);
        }
    }

    public void SetDescriptionActive(string des)
    {
        description.text = des;
    }

    public void SetItemsActive()
    {
        Items.SetActive(true);
    }
}

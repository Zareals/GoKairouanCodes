using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject slots;
    public GameObject description;

    public Image fillBar;
    public Text score;

    int number = 0;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fillBar.fillAmount += 0.1f;
            number += 1;
            score.text = "Items : " + number + "/10";
            Destroy(gameObject);
            for (int i = 0; i < inventory.slot.Length; i++)
            {
                if (inventory.isFull[i]==false)
                {
                    slots.SetActive(true);
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slot[i].transform, false);
                    
                    break;
                }
            }
        }
    }

    public void showDescription(int idx)
    {
        description.SetActive(true);
    }
}

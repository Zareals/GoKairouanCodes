using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour
{
    public GameObject shopItem;
    public GameObject shops;

    public Text des;
    public Image main;
    public Sprite[] items;
    
    public void shop()
    {
        shopItem.SetActive(true);
    }

    public void OpenDescription(string description)
    {
        des.text = description;
        
    }

    public void OpenPicture(int idx)
    {
        main.sprite = items[idx];
        main.color = new Color(255, 255, 255, 255);
    }

    public void SetShopOff()
    {
        shops.SetActive(false);
    }
}

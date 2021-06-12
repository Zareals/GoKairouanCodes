using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneItems : MonoBehaviour
{
    //Map
    public GameObject map;
    //System Date
    public Text Display;
    int hour;
    int minute;
    //MainMenu
    //Contacts : Update
    //Album
    //public GameObject album;

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        Display.text = "" + hour + " : " + minute;
    }

    public void callMap()
    {
        map.SetActive(true);
    }


}

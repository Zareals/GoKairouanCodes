using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phone;
    public GameObject pnl;

    public Animator anim;

    bool isClicked = false;
    
    public void onClick()
    {
        if (isClicked == false)
        {
            Debug.Log("hey");
            pnl.SetActive(true);
            phone.SetActive(true);
            anim.SetBool("UP", true);
            isClicked= true;
        }
        else
        {
            Debug.Log("hey2");
            pnl.SetActive(false);
            phone.SetActive(false);
            isClicked = false;
        }

        
    }
}

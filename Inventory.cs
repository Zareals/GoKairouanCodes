using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fixed
public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slot;
    public GameObject invUI;
    bool isOpen = false;

    private void Start()
    {
        isOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(toggleINv());
            invUI.SetActive(toggleINv());
        }
    }
    private bool toggleINv()
    {
        isOpen = !invUI.activeSelf;
        return isOpen;
    }
}

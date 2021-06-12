using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBar : MonoBehaviour
{
    public Image collectBar;
    void Start()
    {
        collectBar = GetComponent<Image>();
    }
}

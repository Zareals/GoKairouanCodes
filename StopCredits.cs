﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCredits : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}

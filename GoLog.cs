using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoLog : MonoBehaviour
{
    public Text text;
    public GameObject log;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            log.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        log.SetActive(false);
    }

    public void Log(string service)
    {
        text.text = service;
    }
}

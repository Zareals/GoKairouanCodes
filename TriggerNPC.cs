using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerNPC : MonoBehaviour
{
    public GameObject Hint;
    public GameObject selectMenu;
    public GameObject dialogue;
    GameObject Player;

    GameObject miniMap;

    bool isColliding = false;


    //Audio
    public AudioClip greeting;
    AudioSource src;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        miniMap = GameObject.FindGameObjectWithTag("Mini Map");
        src = AudioSource.FindObjectOfType<AudioSource>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            isColliding = true;
            Hint.SetActive(true);
            gameObject.transform.LookAt(Player.transform);
            src.PlayOneShot(greeting);
            miniMap.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
        Hint.SetActive(false);
        selectMenu.SetActive(false);
        dialogue.SetActive(false);

        miniMap.SetActive(true);
    }

    private void Update()
    {
        if (isColliding == true && Input.GetKeyDown(KeyCode.E))
        {
            selectMenu.SetActive(true);
            Hint.SetActive(false);
        }
    }
}

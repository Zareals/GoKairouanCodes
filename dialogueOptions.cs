using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueOptions : MonoBehaviour
{
    public GameObject story;
    public GameObject shop;

    public GameObject theBox;

    public void tellStory()
    {
        story.SetActive(true);
        theBox.SetActive(false);
    }

    public void Shop()
    {
        shop.SetActive(true);
        theBox.SetActive(false);
    }

    public void Exit()
    {
        theBox.SetActive(false);
    }

    public void close()
    {
        story.SetActive(false);
        shop.SetActive(false);
    }
}

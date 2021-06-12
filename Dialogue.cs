using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    static public Dialogue instance;

    public Text textDisplay;
    public string[] sentences;
    public int index;
    public float typingSpeed;

    public int endIndex;

    public GameObject continueButton;

    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Next();
        }

        resetDialogue();

    }
    public void Next()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

    public void resetDialogue()
    {
        if (index == endIndex)
        {
            index = 0;
        }
    }
}

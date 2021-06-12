using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideUI : MonoBehaviour
{
    public GameObject[] guidePage;
    int idx = 0;
    void Start()
    {
        guidePage[0].transform.localScale = Vector2.zero;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GuideMenu();
        }
    }

    public void GuideMenu()
    {
        guidePage[0].SetActive(true);
        guidePage[0].transform.LeanScale(Vector2.one, 0.4f);
    }

    public void NextPage()
    {
        idx++;
        if (idx >= guidePage.Length)
        {
            idx = 0;
        }
        guidePage[idx].SetActive(true);
        guidePage[idx - 1].SetActive(false);
    }

    public void PrevPage()
    {
        idx--;
        if (idx <= guidePage.Length)
        {
            idx = guidePage.Length;
        }
        guidePage[idx].SetActive(true);
        guidePage[idx + 1].SetActive(false);
    }

    public void CloseGuide()
    {
        guidePage[0].transform.localScale = Vector2.zero;
        for (int i = 0; i < guidePage.Length; i++)
        {
            guidePage[i].SetActive(false);
        }
    }

    public void Teleport(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
}

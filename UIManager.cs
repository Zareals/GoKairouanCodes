using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;

    bool isOpen = false;

    void Start()
    {
        isOpen = false;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.P)))
        {
            Pause();
        }

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("working");
        
    }

    public void Pause()
    {
        pauseMenu.SetActive(toggleMenu());
        if (isOpen == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }

    public void BacktoMenu(int index)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private bool toggleMenu()
    {
        isOpen = !pauseMenu.activeSelf;
        return isOpen;
    }
}

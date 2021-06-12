using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject LoadingScreen;
    public AudioSource src;


    public void play()
    {
        LoadingScreen.SetActive(true);
        //PGameManager.instance.LoadGame();
    }

    public void MuteBtn()
    {
        src.mute = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}

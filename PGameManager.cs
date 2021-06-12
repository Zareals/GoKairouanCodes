using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PGameManager : MonoBehaviour
{
    public static PGameManager instance;
    public GameObject loading;

    private void Awake()
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneIndex.Menu, LoadSceneMode.Additive);
    }

    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync((int)SceneIndex.Menu);
        SceneManager.LoadSceneAsync((int)SceneIndex.GOComunity, LoadSceneMode.Additive);
        //SceneManager.LoadSceneAsync((int)SceneIndex.Jraba, LoadSceneMode.Additive);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

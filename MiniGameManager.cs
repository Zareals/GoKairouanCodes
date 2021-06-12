using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public void StartMini(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}

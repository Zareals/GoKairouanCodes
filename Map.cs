using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void Go(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(skip());
    }

    IEnumerator skip()
    {
        yield return new WaitForSeconds(10);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

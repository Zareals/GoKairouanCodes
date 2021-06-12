using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    public GameObject pnl;
    private void Start()
    {
        //StartCoroutine(StopCamera());
        pnl.transform.localScale = Vector2.zero;
        Open();
    }
    public void Open()
    {
        pnl.SetActive(true);
        pnl.transform.LeanScale(Vector2.one, 0.4f);
    }

    public void Close()
    {
        pnl.transform.LeanScale(Vector2.zero, 0.4f).setEaseInBack();
        StartCoroutine(SecondtoClose());
    }

    IEnumerator SecondtoClose()
    {
        yield return new WaitForSeconds(0.5f);
        pnl.SetActive(false);
        Time.timeScale = 1f; 
    }

    /*IEnumerator StopCamera()
    {
        yield return new WaitForSeconds(0.6f);
        Time.timeScale = 0f;
    }*/
}

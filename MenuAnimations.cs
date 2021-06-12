using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{
    public GameObject pnl;
    private void Start()
    {
        pnl.transform.localScale = Vector2.zero;
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
    }
}

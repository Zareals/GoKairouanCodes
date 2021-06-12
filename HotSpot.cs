using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotSpot : MonoBehaviour
{
    public Text NameHolder;

    public GameObject Holder;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NameHolder.text = name;
            Holder.SetActive(true);
            StartCoroutine(SetShowTime());
        }
    }

    IEnumerator SetShowTime()
    {
        yield return new WaitForSeconds(3);
        Holder.SetActive(false);
    }
}

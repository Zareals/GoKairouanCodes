using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpObj : MonoBehaviour
{
    public GameObject UI;
    public Image Bar;
    public float fillAmounts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUps"))
        {
            Destroy(other.gameObject);
            Bar.fillAmount = Bar.fillAmount + fillAmounts ;
            Debug.Log(Bar.fillAmount);
            UI.SetActive(true);
            UI.GetComponentInChildren<Text>().text = "You Have Picked " + other.name + " !";
            StartCoroutine(CloseafterDelay());
        }
    }

    IEnumerator CloseafterDelay()
    {
        yield return new WaitForSeconds(5f);
        UI.SetActive(false);
    }
}

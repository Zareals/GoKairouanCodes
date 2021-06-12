using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditANim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.move(gameObject.GetComponent<RectTransform>(), Vector3.up * 100,15f).setDelay(1f);
        StartCoroutine(LoopCredit());
    }

    IEnumerator LoopCredit()
    {
        yield return new WaitForSeconds(16f);
        LeanTween.move(gameObject.GetComponent<RectTransform>(), Vector3.down * 100, 15f).setDelay(1f);
    }
}

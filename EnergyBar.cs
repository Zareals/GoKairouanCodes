using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    Image energy;
    float time = 1500;
    void Start()
    {
        energy = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        energy.fillAmount = time;
    }
}

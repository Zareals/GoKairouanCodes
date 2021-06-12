using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixJaw : MonoBehaviour
{
    public GameObject Jaw;
    public GameObject LowJaw;

    void Start()
    {
        Jaw.transform.position = new Vector3(0, 0, 0);
        LowJaw.transform.position = new Vector3(0, 0, 0);
    }
}

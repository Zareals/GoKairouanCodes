using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTeleportation : MonoBehaviour
{
    public GameObject teleport;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            teleport.SetActive(true);
        }
    }
}

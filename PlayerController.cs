using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    
    //private bool isWalking;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();
        float moveF = joystick.Horizontal;
        float moveL = joystick.Vertical;

        rb.velocity = new Vector3(moveF * speed,
                                   rb.velocity.y,
                                   moveL * speed
                                  );

    }

   
}

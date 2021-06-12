using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator1 : MonoBehaviour
{
    AI controller;
    public waypoint currentWaypoint;

    private void Awake()
    {
        controller = GetComponent<AI>();
    }
    void Start()
    {
        controller.SetDestination(currentWaypoint.getPosition());
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.reachedDistination)
        {
            currentWaypoint = currentWaypoint.nextWaypoint;
            controller.SetDestination(currentWaypoint.getPosition());
        }
    }
}

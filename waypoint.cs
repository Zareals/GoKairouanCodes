using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    public waypoint previousWaypoint;
    public waypoint nextWaypoint;

    [Range(0f, 15f)]
    public float width = 15f;

    public Vector3 getPosition()
    {
        Vector3 maxBound = transform.position + transform.right * width / 2;
        Vector3 minBound = transform.position - transform.right * width / 2;

        return Vector3.Lerp(minBound, maxBound, Random.Range(0f, 1f));
    }
}

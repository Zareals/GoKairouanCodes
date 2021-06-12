using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    public float speed;
    private GameObject[] points;
    private Transform targetedPoints;
    [SerializeField] GameObject cube;
    [SerializeField] string PatrolPointName;

    void Start()
    {
        points = GameObject.FindGameObjectsWithTag(PatrolPointName);
        targetedPoints = points[Random.Range(0, points.Length)].transform;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(cube.transform);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetedPoints.position, step);
    }
}

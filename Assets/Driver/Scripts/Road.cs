using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed;
    public Transform roadSpot;
    public Transform newRoadPos;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, roadSpot.position, speed * Time.deltaTime);

        if (transform.position == roadSpot.position)
        {
            transform.position = newRoadPos.position;
        }
    }
}

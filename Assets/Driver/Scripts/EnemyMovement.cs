using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3;

    private void Update()
    {
        transform.position -= new Vector3(0, 1 * speed * Time.deltaTime, 0);

        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}

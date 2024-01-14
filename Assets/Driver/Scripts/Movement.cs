using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject enemy;

    public float defaultTimer = 3;
    float Timer;

    private void Update()
    {
        Timer -= Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            
            if (transform.position.x <=  -4.1f)
                transform.position -= new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            
            if (transform.position.x >= 4.1f)
                transform.position -= new Vector3(1 * speed * Time.deltaTime, 0, 0);
        }

        if (Timer <= 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(-4.1f, 4.1f), 10, 0), Quaternion.identity);
            Timer = defaultTimer;
        }
    }
}

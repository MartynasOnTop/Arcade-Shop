using UnityEngine;
using System.Collections;
using UnityEditor;

public class Example : MonoBehaviour
{
    public GameObject[] machines;
    public GameObject customer;

    public float timer;
    public float defaultTimer = 3;

    new Vector3 offset;

    private void Start()
    {
        timer = defaultTimer;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            var index = Random.Range(0, machines.Length);
            if (index > machines.Length / 2)
            {
                offset = new Vector3(1.5f, 0.5f, 0);
            }
            else
            {
                offset = new Vector3(-1.5f, 0.5f, 0);
            }
            Instantiate(customer);
            customer.transform.position = machines[index].transform.position + offset;

            timer = defaultTimer;
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEditor;

public class Example : MonoBehaviour
{
    public GameObject[] machines;
    public GameObject[] customer;

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
            var customerIndex = Random.Range(0, customer.Length);
            if (index > machines.Length / 2)
            {
                offset = new Vector3(1.5f, 0, 0);
                customer[customerIndex].transform.eulerAngles = new Vector3(0, -90, 0);
            }
            else
            {
                offset = new Vector3(-1.5f, 0, 0);
                customer[customerIndex].transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            if (index == machines.Length / 2)
            {
                offset = new Vector3(0.5f, 0, 0);
            }
            else
            {
                offset = new Vector3(-0.5f, 0, 0);
            }
            Instantiate(customer[customerIndex]);
            customer[customerIndex].transform.position = machines[index].transform.position + offset;

            timer = defaultTimer;
        }
    }
}

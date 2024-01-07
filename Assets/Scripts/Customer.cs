using UnityEngine;
using System.Collections;
using UnityEditor;

public class Example : MonoBehaviour
{
    public GameObject[] machines;
    public GameObject[] customers;

    public float timer;
    public float defaultTimer = 3;

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
            var customersIndex = Random.Range(0, customers.Length);

            var Customer = customers[customersIndex];
            var Machine = machines[index];

            Instantiate(Customer, transform.position, transform.rotation);
            if (index > machines.Length / 2)
            {
                Customer.transform.eulerAngles = new Vector3(0, -90, 0);
            }
            else
            {
                Customer.transform.rotation = Quaternion.Euler(0, 90, 0);
            }

            Customer.transform.position = Vector3.MoveTowards(Customer.transform.position, Machine.transform.position, 5f * Time.deltaTime);

            timer = defaultTimer;
        }
    }
}

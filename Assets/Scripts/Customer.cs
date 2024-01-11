using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.AI;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

public class Example : MonoBehaviour
{
    public GameObject[] machines;
    public GameObject[] customers;

    NavMeshAgent agent;

    public Transform exit;

    public float speed = 3f;

    float timer;
    public float defaultTimer = 5;
    public float waitTimer = 8;
    public float playTimer;

    bool isOccupied;

    private void Start()
    {
        timer = defaultTimer;
        isOccupied = false;
    }
    private void Update()
    {
        machines = GameObject.FindGameObjectsWithTag("Arcade");
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = defaultTimer;

            var index = Random.Range(0, machines.Length);
            var customersIndex = Random.Range(0, customers.Length);

            var Customer = customers[customersIndex];
            var Machine = machines[index];

            var shoper = Instantiate(Customer, transform.position, transform.rotation);

            agent = shoper.GetComponent<NavMeshAgent>();

            agent.speed = speed;

            agent.destination = Machine.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profit : MonoBehaviour
{
    public int profit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Customer"))
        {
            GameManager.money += profit;
            Destroy(other.gameObject);
        }
    }
}

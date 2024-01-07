using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade : MonoBehaviour
{
    public GameObject machine;
    public int price;
    public int profit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Player") && price <= GameManager.money)
        {
            machine.SetActive(true);
            Destroy(gameObject);
        }
    }
    public void salary()
    {
        GameManager.money += profit;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Profit : MonoBehaviour
{
    public int profit;

    public AudioClip money;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Customer"))
        {
            GameManager.money += profit;
            AudioSource.PlayClipAtPoint(money, transform.position);
            Destroy(other.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade : MonoBehaviour
{
    public GameObject machine;
    public GameObject playPosition;
    public int price;

    public GameObject Option;

    private void OnTriggerStay(Collider other)
    {
        if (other.name.Contains("Player") && price <= GameManager.money)
        {
            Option.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Option.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) & Option.active)
        {
            playPosition.SetActive(true);
            machine.SetActive(true);
            Destroy(gameObject);
            Option.SetActive(false);
        }
    }
}

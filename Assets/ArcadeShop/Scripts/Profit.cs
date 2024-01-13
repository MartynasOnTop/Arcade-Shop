using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profit : MonoBehaviour
{
    public int profit;
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Customer"))
        {
            GameManager.money += profit;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject playOption;
    public string sceneName;

    private void OnTriggerStay(Collider other)
    {
        if (other.name.Contains("Player"))
        {
            playOption.SetActive(true);
        }
        if (playOption.active == true & Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playOption.SetActive(false);
    }
}

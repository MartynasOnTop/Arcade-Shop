using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTeleporter : MonoBehaviour
{
    public string sceneName;

    public void Pressed()
    {
        SceneManager.LoadScene(sceneName);
    }
}

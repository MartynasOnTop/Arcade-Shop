using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int money;
    public TMP_Text salary;

    private void Update()
    {
        salary.text = "Money: " + money.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;

    public float defaultTimer = 3;
    public float Timer;
    public Transform spawner;
    public float speed = 20f;

    public TMP_Text scoreText;
    public TMP_Text healthText;

    public Transform trailPoint;

    public static int Health = 3;
    public static int score;

    private void Start()
    {
        Timer = defaultTimer;
        Health = 3;
    }
    private void Update()
    {
        Timer -= Time.deltaTime;

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        trailPoint.position = mousePos - Vector3.back;

        scoreText.text = "Score: " + score.ToString();
        healthText.text = Health.ToString();

        if (Timer <= 0)
        {
            var index = Random.Range(0, fruits.Length);

            var fruit = Instantiate(fruits[index], spawner.position, Quaternion.EulerRotation(0, 0, Random.Range(0, 90)));
            var rb = fruit.GetComponent<Rigidbody2D>();

            rb.AddForce(Vector2.up * speed);
            rb.AddForce(Vector2.right * Random.Range(-150, 150));

            Timer = defaultTimer;
        }
        if (Health <= 0)
        {
            SceneManager.LoadScene("NinjaOver");
        }
    }
}
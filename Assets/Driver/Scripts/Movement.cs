using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject enemy;

    float score;
    public TMP_Text scoreText;

    public float defaultTimer = 3;
    float Timer;

    private void Update()
    {
        Timer -= Time.deltaTime;
        score += Time.deltaTime * 10;

        scoreText.text = score.ToString();

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            
            if (transform.position.x <=  -4.1f)
                transform.position -= new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            
            if (transform.position.x >= 4.1f)
                transform.position -= new Vector3(1 * speed * Time.deltaTime, 0, 0);
        }

        if (Timer <= 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(-4.1f, 4.1f), 10, 0), Quaternion.identity);
            Timer = defaultTimer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("policeCar"))
        {
            SceneManager.LoadScene("DriverOver");
        }
    }
}

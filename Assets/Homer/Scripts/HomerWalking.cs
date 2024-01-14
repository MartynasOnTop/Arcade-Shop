using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HomerWalking : MonoBehaviour
{
    public Animator animator;
    public GameObject[] eatables;
    public float speed = 0.03f;

    public TMP_Text scoreText;
    public string sceneName;

    public GameObject[] hearts;

    public int maxHealth = 3;
    public static int health;
    public static int score;

    public float cooldownTimer = 3f;
    public float timer;

    private void Start()
    {
        timer = cooldownTimer;
        health = maxHealth;
    }
    private void Update()
    {
        timer -= Time.deltaTime;

        scoreText.text = "Score: " + score.ToString();

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            animator.Play("Walking");
            if (transform.position.x < -6.3)
            {
                transform.position -= new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            animator.Play("Walking");
            if (transform.position.x > 6.3)
            {
                transform.position -= new Vector3(1 * speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            animator.Play("Idle");
        }

        if (timer <= 0)
        {
            var index = Random.Range(0, eatables.Length);
            var Object = Instantiate(eatables[index], new Vector3(Random.Range(-7, 7), 7, 0), Quaternion.identity);
            timer = cooldownTimer;
        }
        if (health < hearts.Length)
        {
            Destroy(hearts[health]);
            if (health == 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}

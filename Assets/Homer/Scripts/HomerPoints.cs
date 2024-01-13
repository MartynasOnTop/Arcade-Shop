using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomerPoints : MonoBehaviour
{
    public int damage;
    public int points;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Homer"))
        {
            HomerWalking.health -= damage;
            HomerWalking.score += points;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y <= -4)
        {
            Destroy(gameObject);
        }
    }
}
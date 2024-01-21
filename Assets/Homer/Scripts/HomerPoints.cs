using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomerPoints : MonoBehaviour
{
    public int damage;
    public int points;

    public AudioClip explosionSound;

    public ParticleSystem explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Homer"))
        {
            HomerWalking.health -= damage;
            HomerWalking.score += points;

            AudioSource.PlayClipAtPoint(explosionSound, Vector3.zero);

            Instantiate(explosion, gameObject.transform.position += new Vector3(0, 0, -4), Quaternion.identity);
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
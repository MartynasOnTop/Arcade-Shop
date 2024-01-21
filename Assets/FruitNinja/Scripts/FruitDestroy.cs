using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FruitsDestroy : MonoBehaviour
{
    public ParticleSystem fruitCut;
    public int damage;
    public int score;

    public AudioClip cutSound;

    private void OnMouseOver()
    {
        FruitSpawner.Health -= damage;
        FruitSpawner.score += score;
        var Cut = Instantiate(fruitCut, transform.position += new Vector3(0, 0, -4), Quaternion.identity);

        AudioSource.PlayClipAtPoint(cutSound, Vector3.zero);

        Cut.Play();
        Destroy(gameObject);
    }
    private void Update()
    {
        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
        foreach (GameObject cutSound in GameObject.FindGameObjectsWithTag("Cut"))
        {
            Destroy(cutSound);
        }
    }
}
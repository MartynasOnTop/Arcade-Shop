using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsDestroy : MonoBehaviour
{
    public ParticleSystem fruitCut;
    public int damage;
    public int score;

    private void OnMouseOver()
    {
        FruitSpawner.Health -= damage;
        FruitSpawner.score += score;
        Destroy(gameObject);
    }
    private void Update()
    {
        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
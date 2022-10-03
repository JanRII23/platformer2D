using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    MainEnemyGuard explode;

    private void Start()
    {
        explode = GameObject.FindGameObjectWithTag("Enemy").GetComponent<MainEnemyGuard>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {         
            explode.EnemyGuardParticle();
            Destroy(collision.gameObject, .10f);
            Destroy(gameObject); //destroys bullet when hitting enemy
        }

        else if (collision.CompareTag("TilemappedLevel"))
        {
            Destroy(gameObject);
        }
    }
}

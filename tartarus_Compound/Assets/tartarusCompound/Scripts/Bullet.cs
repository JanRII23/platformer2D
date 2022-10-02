using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    EnemyGuard explode;

    private void Start()
    {
        explode = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyGuard>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {         
            explode.EnemyGuardParticle();
            Destroy(collision.gameObject, .25f);
            Destroy(gameObject); //destroys bullet when hitting enemy
        }

        else if (collision.CompareTag("TilemappedLevel"))
        {
            Destroy(gameObject);
        }
    }
}

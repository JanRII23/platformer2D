using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{

    //MainEnemyGuard explode;


    [SerializeField] MainEnemyGuard enemyOne;
    [SerializeField] MainEnemyGuard enemyTwo;


    private void Start()
    {
        //explode = GameObject.FindGameObjectWithTag("Enemy").GetComponent<MainEnemyGuard>();
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.name == "enemyBot")
            {
                enemyOne.EnemyGuardParticle();
                //explode.EnemyGuardParticle();

               
                Destroy(collision.gameObject, .10f);

            }
            else if (collision.gameObject.name == "enemyBotOne")
            {
                //explode.EnemyGuardParticle();
                enemyTwo.EnemyGuardParticle();
                Destroy(collision.gameObject, .10f);
            }



        }
    }
}

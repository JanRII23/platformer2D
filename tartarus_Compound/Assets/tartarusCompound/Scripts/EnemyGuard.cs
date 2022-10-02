using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGuard : MonoBehaviour
{
    private Rigidbody2D rb; //caching the components; make sure to make it private and not expose it to use in other scripts
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D coll;

    [SerializeField] private GameObject testGuard;
    //kind of a hackysolution

    private 


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //do this you can use the component
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>(); //animator component

    }

    // Update is called once per frame
    void Update()
    {

      
        
    }

    public void EnemyGuardParticle()
    {
        anim.Play("Enemy_Vaporate");


    }
}

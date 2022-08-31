using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb; //caching the components; make sure to make it private and not expose it to use in other scripts
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f; //serializedfield allows the edits of value in the editor
    [SerializeField] private float jumpForce = 14f;
    
    //data types int = 16, float = 4.45f, string = "bla", bool = true/false

    // Start is called before the first frame update
    private void Start() //methods should be private as well
    {
        rb = GetComponent<Rigidbody2D>(); //do this you can use the component
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>(); //animator component
    }

    // Update is called once per frame
    private void Update()
    {
        //This actually has joystick support
        dirX = Input.GetAxisRaw("Horizontal"); //getAxis has slight decelaration, getAxisRaw tries to minimize it
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //when creating variables make sure to keep in the smallest scope, notice how dirX was not initialize similar to rb up top


        if(Input.GetButtonDown("Jump")) //using GetButtonDown is referring to the values in the input Manager

            //getkey has the effect of constantly adding velocity is a key is pressed 
            //getkeyDown only applies for a brief time --> note that both these types do not refer to the input manager in Unity but hard coded
        {
           rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0); //vector3(x, y, z), optional but can also use Vector2
        }

        //note that transition can be paused momentarily

        UpdateAnimationState();
       
    }

    private void UpdateAnimationState()
    {
        if (dirX > 0f)
        {
            //make sure spelling within animator is exact
            anim.SetBool("running", true); //running right
            sprite.flipX = false;

        }
        else if (dirX < 0f) //note that i Know you can change which direction the character is facing via sprite flipX
        {
            anim.SetBool("running", true);//running left
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }

    }
}

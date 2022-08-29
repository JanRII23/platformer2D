using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb; //caching the components; make sure to make it private and not expose it to use in other scripts
    
    //data types int = 16, float = 4.45f, string = "bla", bool = true/false

    // Start is called before the first frame update
    private void Start() //methods should be private as well
    {
        rb = GetComponent<Rigidbody2D>(); //do this you can use the component
    }

    // Update is called once per frame
    private void Update()
    {
        //This actually has joystick support
        float dirX = Input.GetAxisRaw("Horizontal"); //getAxis has slight decelaration, getAxisRaw tries to minimize it
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        //when creating variables make sure to keep in the smallest scope, notice how dirX was not initialize similar to rb up top


        if(Input.GetButtonDown("Jump")) //using GetButtonDown is referring to the values in the input Manager

            //getkey has the effect of constantly adding velocity is a key is pressed 
            //getkeyDown only applies for a brief time --> note that both these types do not refer to the input manager in Unity but hard coded
        {
           rb.velocity = new Vector3(rb.velocity.x, 14f, 0); //vector3(x, y, z), optional but can also use Vector2
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Ransom;
    public bool saltando = false;
    public bool isGrounded;
    public KeyCode jump;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    // Start is called before the first frame update
    void Start()
    {
        Ransom = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
        //Store the current vertical input in the float moveVertical.
        if (Input.GetKeyDown(jump) || Input.GetAxis("Jump")==1)
        {
            Debug.Log("Hola muy buenas a todos");
            saltando = true;
             Ransom.velocity = new Vector2(moveHorizontal, Ransom.velocity.y+3); ;
            Ransom.AddForce(Ransom.velocity * speed);

        }
        // float moveVertical = Input.GetAxis("Vertical");
        saltando = false;
        //Use the two store floats to create a new Vector2 variable movement.
        Ransom.velocity = new Vector2(moveHorizontal, 0);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
       Ransom.AddForce(Ransom.velocity * speed);
    }
}



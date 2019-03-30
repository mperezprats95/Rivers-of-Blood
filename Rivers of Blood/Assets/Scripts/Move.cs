using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public LayerMask whatIsGround;
    public Transform groundCheck;
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    public bool isJumping = true;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                isJumping = true;
            }
        }

    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
            Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
            rb.velocity = move;
        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1.322765f, 1.177472f);
        }
      
        else if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1.322765f, 1.177472f);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "tierra")
        {
            isJumping = false;
        }
    }
}

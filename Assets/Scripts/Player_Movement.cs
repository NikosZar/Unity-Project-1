using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    private bool isgrounded;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

        /* A D Movements */
        if (Input.GetKey(KeyCode.D))
        {
            body.velocity = new Vector2(speed, body.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.velocity = new Vector2(-speed, body.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) && isgrounded)
        {
            Jump();
        }

        void Jump()
        {
            body.velocity = new Vector2(body.velocity.x, speed);
            isgrounded = false;
        }
    }
        /*Check if Grounded by using ground GameTag */
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Ground")
             isgrounded = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    private float jumpheight;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        /* A D Movements */
        if (Input.GetKey (KeyCode.D))
        {
            body.velocity = new Vector2(speed, body.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.velocity = new Vector2(- speed, body.velocity.y);
        }

        if (Input.GetKey (KeyCode.Space))
        {
            Jump();
        }
        
        void Jump()
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }

        /*something */
    }
}

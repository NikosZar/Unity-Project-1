using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D body;
    private float speed;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0.2f;

        /* A D Movements */
        if (Input.GetKey (KeyCode.D))
        {
            transform.Translate(speed, body.velocity.y, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(- speed, body.velocity.y, 0f);
        }


    }
}

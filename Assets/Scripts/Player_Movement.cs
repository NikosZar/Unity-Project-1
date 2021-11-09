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
        if (Input.GetKey (KeyCode.D))
        {
            speed = 0.2f;
            transform.Translate(speed, body.velocity.y, 0f);
        }
    }
}

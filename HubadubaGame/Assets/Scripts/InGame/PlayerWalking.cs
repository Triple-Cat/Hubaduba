using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    float moveInput;
    public Joystick JS;
    Rigidbody2D rb;
    float speed = 4;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        moveInput = JS.Horizontal;
        rb.velocity = new Vector2(moveInput * speed,rb.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    float moveInput;
    public Joystick JS;
    Rigidbody2D rb;
    float speed = 4;
    public GameObject DeathScreen;
    Shooting sh;
    Enemy en;
    public GameObject j;

    void Start()
    {
        en = FindObjectOfType<Enemy>();
        sh = FindObjectOfType<Shooting>();
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        moveInput = JS.Horizontal;
        rb.velocity = new Vector2(moveInput * speed,rb.velocity.y);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyHead") || collision.CompareTag("EnemyBody"))
        {
            DeathScreen.SetActive(true);
            en.enabled = false;
            sh.enabled = false;
            j.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 4;
    Rigidbody2D rb;
    public float HP = 10;
    float damageE = 2;
    public GameObject TextHeadShot;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void ViewHeadShot()
    { 
        TextHeadShot.SetActive(true);
        StartCoroutine(HeadshotText());
    }
    IEnumerator HeadshotText()
    {
        yield return new WaitForSeconds(1f);
        TextHeadShot.SetActive(false);
    }
}

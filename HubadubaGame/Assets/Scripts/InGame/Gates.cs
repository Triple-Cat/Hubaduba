using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{
    int GatesHP = 2;
    public GameObject DeathScreen;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBody"))
        {
            GatesHP -= 2;
        }
    }
    void Update()
    {
        if (GatesHP <= 0)
        {
            DeathScreen.SetActive(true);  
        }
    }
}

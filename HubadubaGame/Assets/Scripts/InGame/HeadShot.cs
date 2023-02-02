using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadShot : MonoBehaviour
{
    Enemy enm;
    Shooting arrw;
    GameObject blood;
    void Start()
    {
        enm = FindObjectOfType<Enemy>();
        arrw = FindObjectOfType<Shooting>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            enm.ViewHeadShot();
            enm.HP -= arrw.damageR * 2;

            Destroy(arrw);
        }
    }
}

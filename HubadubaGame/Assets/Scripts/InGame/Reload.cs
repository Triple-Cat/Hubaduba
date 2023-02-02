using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Arrow;
    //float TimeToReload = 2;
    //float CurrentTime = 0;

    void Update()
    {
        
    //    if (Input.GetMouseButton(0))
    //    {
    //        if (Input.mousePosition.x > Screen.width / 2)
    //        {
    //            if (CurrentTime <= TimeToReload)
    //            {
    //                Instantiate(Arrow, SpawnPos);
    //            }
    //        }
    //        CurrentTime = TimeToReload;
    //    }
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        if (Input.mousePosition.x > Screen.width / 2)
    //        { 
                    
    //        }
    //    }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Bow"))
        {
            StartCoroutine(CReload());
        }
    }
    IEnumerator CReload()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(Arrow, SpawnPos);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Enemy enm;
    public float damageR = 5;
    public float power = 10f;
    Rigidbody2D rb;
    public Vector2 minPower;
    public Vector2 maxPower;
    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    RendLine rl;

    private void Start()
    {
        enm = GetComponent<Enemy>();
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        rl = GetComponent<RendLine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 0;
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                currentPoint.z = 0;
                rl.RenderLine(startPoint, currentPoint);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 0;
                rb.isKinematic = false;
                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
                rl.EndLine();
                StartCoroutine(LetDestroy());
            }
        }
    }
    IEnumerator LetDestroy()
    {
        yield return new WaitForSeconds(0.1f);
        this.enabled = false;
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mouseDirection = (mousePos - (Vector2)transform.position).normalized;
        rb.velocity = mouseDirection * speed;
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if(!hitObj.gameObject.name.Contains("Player"))
            Destroy(gameObject);
    }

}

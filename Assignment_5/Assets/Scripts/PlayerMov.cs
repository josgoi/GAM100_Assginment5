using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb ;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mouseDirection = (mousePos - (Vector2)transform.position).normalized;
            transform.up = mouseDirection;
        }

        Vector2 move = Vector2.zero; 
    
        if(Input.GetKey(KeyCode.W))
        {
            move.y += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.y -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move.x += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x -= speed;
        }

        rb.velocity = new Vector3(move.x, move.y, 0);
    }
}

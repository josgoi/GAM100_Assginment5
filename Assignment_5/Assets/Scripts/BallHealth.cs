using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{

    int Health = 5;

    void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<Shooting>().BallsDestroyed++;
        }
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (!hitObj.gameObject.name.Contains("Bullet"))
        {
            Health--;
        }
    }
}

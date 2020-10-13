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
            GameObject.Find("Player").GetComponent<Shooting>().TotalBalls--;
            GameObject.Find("Player").GetComponent<Shooting>().BallsLeftText();
        }
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("Bullet"))
        {
            Health--;
        }
    }
}

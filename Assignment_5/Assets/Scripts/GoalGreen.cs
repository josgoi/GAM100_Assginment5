using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGreen : MonoBehaviour
{
    int Score;

    void Start()
    {
        Score = 0;
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallGreen"))
        {
            Destroy(hitObj.gameObject);
            Score += 200;
        }
        else if (hitObj.gameObject.name.Contains("SmallBallGreen"))
        {
            Destroy(hitObj.gameObject);
            Score += 100;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlue : MonoBehaviour
{
    int Score;

    void Start()
    {
        Score = 0;
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallBlue"))
        {
            Destroy(hitObj.gameObject);
            Score += 200;
        }
        else if (hitObj.gameObject.name.Contains("SmallBallBlue"))
        {
            Destroy(hitObj.gameObject);
            Score += 100;
        }
    }
}

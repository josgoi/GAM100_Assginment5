using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoalRed : MonoBehaviour
{
    int Score;

    void Start()
    {
        Score = 0;
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallRed"))
        {
            Destroy(hitObj.gameObject);
            Score += 200;
        }else if (hitObj.gameObject.name.Contains("SmallBallRed"))
        {
            Destroy(hitObj.gameObject);
            Score += 100;
        }
    }
}
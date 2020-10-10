﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoalRed : MonoBehaviour
{
    private Score;

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallRed"))
        {
            Destroy(hitObj.gameObject);
            GoalYellow.Score += 200;
        }else if (hitObj.gameObject.name.Contains("SmallBallRed"))
        {
            Destroy(hitObj.gameObject);
            GoalYellow.Score += 100;
        }
    }
}
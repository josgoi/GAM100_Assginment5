using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoalRed : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallRed"))
        {
            Destroy(hitObj.gameObject);
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().Score += 200;
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().SetScoreText();
        }
        else if (hitObj.gameObject.name.Contains("SmallBallRed"))
        {
            Destroy(hitObj.gameObject);
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().Score += 100;
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().SetScoreText();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGreen : MonoBehaviour
{
    void Start()
    {
       
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallGreen"))
        {
            Destroy(hitObj.gameObject);
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().Score += 200;
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().SetScoreText();
        }
        else if (hitObj.gameObject.name.Contains("SmallBallGreen"))
        {
            Destroy(hitObj.gameObject);
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().Score += 100;
            GameObject.Find("GoalYellow").GetComponent<GoalYellow>().SetScoreText();
        }
    }
}

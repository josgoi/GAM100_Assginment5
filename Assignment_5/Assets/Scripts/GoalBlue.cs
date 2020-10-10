using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlue : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallBlue"))
        {
            Destroy(hitObj.gameObject);
            GoalYellow.Score += 200;
        }
        else if (hitObj.gameObject.name.Contains("SmallBallBlue"))
        {
            Destroy(hitObj.gameObject);
            GoalYellow.Score += 100;
        }
    }
}

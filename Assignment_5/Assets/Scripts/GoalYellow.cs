using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalYellow : MonoBehaviour
{

    public int Score = 0;

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallYellow"))
        {
            Destroy(hitObj.gameObject);
            Score += 200;
        }else if (hitObj.gameObject.name.Contains("SmallBallYellow"))
        {
            Destroy(hitObj.gameObject);
            Score += 100;
        }
    }
}

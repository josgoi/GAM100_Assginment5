using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalYellow : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int Score = 0;

    void Start()
    {
        Score = 0;
        SetScoreText();
    }

    void OnCollisionEnter2D(Collision2D hitObj)
    {
        if (hitObj.gameObject.name.Contains("BigBallYellow"))
        {
            Destroy(hitObj.gameObject);
            Score += 200;
            SetScoreText();
        }
        else if (hitObj.gameObject.name.Contains("SmallBallYellow"))
        {
            Destroy(hitObj.gameObject);
            Score += 100;
            SetScoreText();
        }
    }

    public void SetScoreText()
    {
        ScoreText.text = "Score:" + Score.ToString();
    }
}

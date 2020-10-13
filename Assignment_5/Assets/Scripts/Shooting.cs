using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int BallsDestroyed = 0;
    public TextMeshProUGUI EndText;
    public GameObject EndTextobject;

    void Start()
    {
        EndTextobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (BallsDestroyed > 10)
        {
            SetEndText();
            EndTextobject.SetActive(true);
        }
    }

    public void SetEndText()
    {
        EndText.text = "Final Score:" + GameObject.Find("GoalYellow").GetComponent<GoalYellow>().Score.ToString();
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] Prefabs;

    float randX;
    float randY;
    Vector2 SpawnPoint;

    public float currentTime = 0.0f;
    public float spawnRate = 1.0f;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > spawnRate)
        {
            Spawn();
            currentTime = 0.0f;
        }
    }

    void Spawn()
    {
        randX = Random.Range(-6.3f, 6.3f);
        randY = Random.Range(-5f, 5f);
        SpawnPoint = new Vector2(randX, randY);

        int randBallColor = Random.Range(0, Prefabs.Length);
        
        Instantiate(Prefabs[randBallColor], SpawnPoint, Quaternion.identity);
    }
}

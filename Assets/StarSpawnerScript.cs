using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawnerScript : MonoBehaviour
{
    public float spawnInterval;

    private Vector2 spawnLocation;
    public float starSpeedatSpawn;
    public GameObject starPrefab;
    private float difficultyRate;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = 5f;
        difficultyRate = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval -= Time.deltaTime;

        //Debug.Log(spawnInterval);
        AdjustDifficulty();
        if (spawnInterval <= 0)
        {
            spawnInterval = UnityEngine.Random.Range(0.5f, difficultyRate);
            Instantiate(starPrefab, new Vector3(gameObject.transform.position.x, UnityEngine.Random.Range(-4f, 4), 0f), Quaternion.identity);

        }
    }

    void AdjustDifficulty()
    {
        switch (ScoreController.score)
        {
            case 300:
                difficultyRate = 4f;
                break;
            case 1000:
                difficultyRate = 2.5f;
                break;
            case 2000:
                difficultyRate = 1.5f;
                break;
            case 3000:
                difficultyRate = 1f;
                break;
        }
    }
}

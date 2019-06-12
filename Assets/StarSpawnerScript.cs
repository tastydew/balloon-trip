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

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval -= 1 * Time.deltaTime;

        Debug.Log(spawnInterval);

        if (spawnInterval <= 0)
        {
            spawnInterval = 5f;
            Instantiate(starPrefab, new Vector3(gameObject.transform.position.x, UnityEngine.Random.Range(-4f, 4),0f), Quaternion.identity);

        }
    }
}

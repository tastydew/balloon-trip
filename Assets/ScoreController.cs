using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text scoreText;
    public static int score;
    private float scoreUpdateInterval;

    void Start()
    {
        scoreUpdateInterval = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreUpdateInterval -= Time.deltaTime;

        if (scoreUpdateInterval <= 0)
        {
            scoreUpdateInterval = 1.5f;
            score += 100;
        }

        scoreText.text = score.ToString().PadLeft(7, '0');
    }
}

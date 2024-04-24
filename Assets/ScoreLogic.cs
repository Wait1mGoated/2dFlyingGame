using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreLogic : MonoBehaviour
{
    bool stopwatchActive = true; //change to false after testing
    float currentTime;
    public Text currentTimeText;

    int alt;
    public Text altText;

    int score;
    public Text scoreText;
    public float multiplier = 2;

    void Start()
    {
        currentTime = 0;
        alt = 0;
        score = 0;
    }

    void Update()
    {
        if (stopwatchActive) 
        {
            currentTime += Time.deltaTime; 
        }
        alt = Mathf.RoundToInt(currentTime * 4);
        altText.text = alt.ToString() + " km";
        score = Mathf.RoundToInt((currentTime + alt) * multiplier);
        scoreText.text = "Score: " + score.ToString();
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch() 
    {
        stopwatchActive = true;
    }

    public void StopStopwatch() 
    {
        stopwatchActive = false;
    }
}

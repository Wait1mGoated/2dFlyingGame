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
    public GameObject ground;

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
        if (currentTime > 2)
        {
            ground.SetActive(false);
        }
        alt = Mathf.RoundToInt(currentTime * 4);
        if (BuyButtons.instance.Launcher1 && BuyButtons.instance.L1Bought)
        {
            alt += 100;
        }
        else if (BuyButtons.instance.Launcher2 && BuyButtons.instance.L2Bought)
        {
            alt += 200;
        }
        else if (BuyButtons.instance.Launcher3 && BuyButtons.instance.L3Bought)
        {
            alt += 400;
        }
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

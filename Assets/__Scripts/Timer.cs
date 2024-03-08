using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float secondsCount = 0f;
    private int minuteCount = 0;

    void FixedUpdate()
    {
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        //Have the time set to the time spent in game
        secondsCount += Time.deltaTime;

        //Format timer to have a 0 in front of colon if below 9 seconds
        if (secondsCount < 9)
        {
            timerText.text = minuteCount + ":0" + secondsCount.ToString("F0");
        }
        else if (secondsCount >= 10)
        {
            timerText.text = minuteCount + ":" + secondsCount.ToString("F0");
        }
        //When we reach 60 seconds add a minute
        else if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }
}

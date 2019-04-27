using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerControl : MonoBehaviour
{
    public float TimerValue;
    public TextMeshProUGUI TimerText;
    private int remainingMinutes, remainingSeconds;
    private float fraction;

    private bool timerStarted;

    void Start()
    {
        TimerText.text = "";
        StartTimer();
    }
    void StartTimer()
    {
        timerStarted = true;
    }

    void Update()
    {
        if (timerStarted && TimerValue >= 0)
        {
            TimerValue -= Time.deltaTime;
            int timerVal = (int)TimerValue;

            remainingMinutes = timerVal / 60;
            remainingSeconds = timerVal % 60;
            fraction = TimerValue * 1000;
            fraction = (fraction % 1000);
            TimerText.text = string.Format("{0:0}:{1:00}", remainingMinutes, remainingSeconds);
        }
        else
        {
            TimerText.text = "0:00";
            timerStarted = false;
        }
    }
}

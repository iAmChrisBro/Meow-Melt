using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class OrderGenerator : MonoBehaviour
{

    private TMP_Text timerText;
    private TMP_Text deliveryProgress;
    public float startTime;
    private bool timerActive;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.FindGameObjectWithTag("TimerText").GetComponent<TMP_Text>();
        deliveryProgress = GameObject.FindGameObjectWithTag("DeliveryProgress").GetComponent<TMP_Text>();
        currentTime = startTime * 60;
        StartTimer();

    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
            currentTime -= Time.deltaTime;

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.Minutes.ToString() + " : " + time.Seconds.ToString();
        
        if(time.Minutes == 0 && time.Seconds == 0)
            StopTimer();
    }

    public void StartTimer()
        { timerActive = true; }

    public void StopTimer()
        { timerActive = false; }
}

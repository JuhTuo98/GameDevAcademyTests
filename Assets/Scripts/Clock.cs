using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Clock : MonoBehaviour
{
    
    public GameObject SecondHand, MinuteHand, HourHand;
    public TextMeshProUGUI TextTime;
    private float flSecond, flMinute, flHour;
    private DateTime time;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time = DateTime.Now;
        flSecond = Mathf.Floor(time.Second) * 6;
        flMinute = Mathf.Floor(time.Minute) * 6;
        flHour = (MathF.Floor(time.Hour) * 30) + flMinute / 12;
        
        
        /*timer += Time.deltaTime;
        flSecond = Mathf.Floor(timer) * 6;
        if (flSecond == 360) {
            flMinute += flSecond / 100;
            flHour += flSecond / 1200;
            timer = 0;
        }*/

        SecondHand.transform.localRotation = Quaternion.Euler(0, -flSecond, 0);
        MinuteHand.transform.localRotation = Quaternion.Euler(0, -flMinute, 0);
        HourHand.transform.localRotation = Quaternion.Euler(0, -flHour, 0);
        TextTime.SetText(time.ToShortTimeString() + "\nsecond: " + flSecond.ToString() + "\nminute: " + flMinute.ToString() + "\nhour: " + flHour.ToString());

    }
}

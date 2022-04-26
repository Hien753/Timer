using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeLimit : MonoBehaviour
{
    public Text TextFrame;
    private int StartTime;
    private int CurrentTime;
    private int min;
    private int sec;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = StartTime - (int)Time.time;
        Minuite();
        Second();
        Write();
    }

    void Minuite()
    {
        min = CurrentTime / 60;
    }

    void Second()
    {
        sec = CurrentTime - min * 60;
    }

    void Write()
    {
        if((int)Time.time > StartTime)
        {
            min = sec = 0;
        }
        TextFrame.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}

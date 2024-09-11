using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    private float time = 0;
    public TextMeshProUGUI time_text;
    public static bool stopTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopTimer)
        {
            time += Time.deltaTime;
        }
        double minutes = Math.Floor(time / 60);
        double seconds = Math.Round(time - minutes * 60, 2);
        time_text.text = minutes.ToString() + ":" + seconds.ToString();
    }
}

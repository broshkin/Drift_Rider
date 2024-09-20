using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Win : MonoBehaviour
{
    public GameObject winUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Timer.time);
        if (GameObject.FindGameObjectsWithTag("Box").Length == 0)
        {
            winUI.SetActive(true);
            Timer.stopTimer = true;
            YandexGame.NewLeaderboardScores("liderbord", Convert.ToInt32(Timer.time * 1000));
            Time.timeScale = 0;
        }
    }
}

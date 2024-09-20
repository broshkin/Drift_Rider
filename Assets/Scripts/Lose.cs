using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject loseUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.health <= 0)
        {
            PlayerHealth.health = 0;
            loseUI.SetActive(true);
            Timer.stopTimer = true;
            Time.timeScale = 0;
        }
    }

    public static void RewardGame()
    {
        Time.timeScale = 1;
        Timer.stopTimer = false;
        GameObject.Find("Manager").GetComponent<Lose>().loseUI.SetActive(false);
        PlayerHealth.health = 100;
        GameObject.Find("CAR (1)").transform.position = PlayerHealth.startPos;
        GameObject.Find("CAR (1)").transform.rotation = PlayerHealth.startRot;
    }
}

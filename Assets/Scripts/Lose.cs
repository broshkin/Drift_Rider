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
}

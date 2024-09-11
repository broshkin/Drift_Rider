using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (GameObject.FindGameObjectsWithTag("Box").Length == 0)
        {
            winUI.SetActive(true);
            Timer.stopTimer = true;
            Time.timeScale = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI health_text;
    [SerializeField]
    private int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health_text.text = health.ToString() + "HP";
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        var power = collision.relativeVelocity.magnitude / 2;
        if (power >= 5)
        {
            health -= Convert.ToInt32(power);
        }
    }
}

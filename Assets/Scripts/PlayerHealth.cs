using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using YG;

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
        if (YandexGame.EnvironmentData.language == "en")
        {
            health_text.text = health.ToString() + "HP";
        }
        if (YandexGame.EnvironmentData.language == "ru")
        {
            health_text.text = health.ToString() + "’œ";
        }
        if (health <= 0 || Input.GetKeyDown(KeyCode.R))
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
    public void HealthUp(int count)
    {
        if (health + count > 100)
        {
            health = 100;
        }
        else
        {
            health += count;
        }
    }
    public int GetHP()
    {
        return health;
    }
}

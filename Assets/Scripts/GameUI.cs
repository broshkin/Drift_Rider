using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject menuButton;
    public GameObject winMenu;
    public GameObject loseMenu;
    public GameObject menu;

    public void RestartButton()
    {
        CloseMenu();
        PlayerHealth.health = 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Timer.time = 0;
        Timer.stopTimer = false;
    }
    public void OpenMenu()
    {
        Time.timeScale = 0;
    }
    public void CloseMenu()
    {
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void TGButton()
    {
        Application.OpenURL("https://t.me/marcostudio");
    }
    public void ReturnToMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (Time.timeScale == 1)
            {
                menu.SetActive(true);
                menuButton.SetActive(false);
                OpenMenu();
            }
            else
            {
                menu.SetActive(false);
                menuButton.SetActive(true);
                CloseMenu();
            }
        }
    }
}

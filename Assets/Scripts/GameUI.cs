using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject menuButton;
    public GameObject menu;

    public void RestartButton()
    {
        CloseMenu();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OpenMenu()
    {
        Time.timeScale = 0;
    }
    public void CloseMenu()
    {
        Time.timeScale = 1;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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

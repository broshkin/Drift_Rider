using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class UiManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup WinContainer, LoseContainer, StartContainer;
    [SerializeField] private Button StartGameButton, RestartGameButton, NextGameButton;
    [SerializeField] private Text MoneyText;
    [SerializeField] private Text LevelText;

    [SerializeField] private Button FirstButtonReward;

    private int currentGold;

    private void Start()
    {
        FirstButtonReward.onClick.AddListener(delegate { ExampleOpenRewardAd(1); });

        currentGold = PlayerPrefs.GetInt("Money", 0);
        GetData();
        YandexGame.FullscreenShow();
    }


    void Rewarded(int id)
    {
        if (id == 1) // Если ID = 1, то выдаём "+100 монет"
        {
            FirstButtonReward.gameObject.SetActive(false);
            Lose.RewardGame();
        }
       
    }

    private void AddMoney(int money)
    {
        currentGold += money;
        MoneyText.text = currentGold.ToString();
        PlayerPrefs.SetInt("Money", currentGold);
    }

    // Метод для вызова видео рекламы
    void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }

   


    public void SetMoney()
    {
        currentGold++;
        PlayerPrefs.SetInt("Money", currentGold);
        MoneyText.text = currentGold.ToString();
    }

    private void NextGame()
    {
        PlayerPrefs.SetInt("CurrentLevel", PlayerPrefs.GetInt("CurrentLevel", 0) + 1);
        SceneManager.LoadScene(0);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void LoseGame()
    {
        LoseContainer.blocksRaycasts = true;
        LoseContainer.alpha = 1;
    }

    public void WinGame()
    {
        WinContainer.blocksRaycasts = true;
        WinContainer.alpha = 1;
    }

    private void StartGame()
    {
        StartContainer.blocksRaycasts = false;
        StartContainer.alpha = 0;
    }

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
        YandexGame.GetDataEvent += GetData;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;
        YandexGame.GetDataEvent -= GetData;
        
    }
    public async void GetData()
    {
        // Дожидаемся, пока SDK не станет доступным
        while (!YandexGame.SDKEnabled)
        {
            await Task.Delay(200); // Можно изменить интервал ожидания (в миллисекундах)
        }
        Task.Delay(100);
        int currentLevel = (PlayerPrefs.GetInt("CurrentLevel", 0) + 1);
        if (YandexGame.EnvironmentData.language == "en")
        {
           // LevelText.text = "Level " + currentLevel.ToString();
        }

        if (YandexGame.EnvironmentData.language == "ru")
        {
           // LevelText.text = "Уровень " + currentLevel.ToString();
        }

        
    }
}
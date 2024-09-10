using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using YG;

public class LootBoxSystem : MonoBehaviour
{
    public TextMeshProUGUI counter_of_loot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (YandexGame.EnvironmentData.language == "en")
        {
            counter_of_loot.text = GameObject.FindGameObjectsWithTag("Box").Length.ToString() + " Lit Energy left";
        }
        if (YandexGame.EnvironmentData.language == "ru")
        {
            counter_of_loot.text = "Осталось " + GameObject.FindGameObjectsWithTag("Box").Length.ToString() + " Lit Energy";

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
        counter_of_loot.text = "Осталось" + GameObject.FindGameObjectsWithTag("Box").Length.ToString() + " Lit Energy";
    }
}

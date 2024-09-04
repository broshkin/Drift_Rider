using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchHeal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponentInParent<PlayerHealth>().GetHP() != 100)
            {
                other.gameObject.GetComponentInParent<PlayerHealth>().HealthUp(20);
                gameObject.SetActive(false);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchLoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, 5);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}

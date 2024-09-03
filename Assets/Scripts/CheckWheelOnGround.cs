using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWheelOnGround : MonoBehaviour
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
        if (other.gameObject.name == "Plane")
        {
            PrometeoCarController.onGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Plane")
        {
            PrometeoCarController.onGround = false;
        }
    }
}

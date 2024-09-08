using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -327)
        {
            transform.position = new Vector3(-327, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 494)
        {
            transform.position = new Vector3(494, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -218)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -218);
        }
        if (transform.position.z > 194)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 194);
        }
    }
}

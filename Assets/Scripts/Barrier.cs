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
        if (transform.position.x < -326)
        {
            transform.position = new Vector3(-326, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 493)
        {
            transform.position = new Vector3(493, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -217)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -217);
        }
        if (transform.position.z > 192)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 192);
        }
    }
}

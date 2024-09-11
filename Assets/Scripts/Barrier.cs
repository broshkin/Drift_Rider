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
        if (transform.position.x < -325.5f)
        {
            transform.position = new Vector3(-325.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 492.5f)
        {
            transform.position = new Vector3(492.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -216.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -216.5f);
        }
        if (transform.position.z > 191.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 191.5f);
        }
    }
}

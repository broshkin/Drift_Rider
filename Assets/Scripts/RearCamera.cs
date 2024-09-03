using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            camera.SetActive(true);
            maincamera.GetComponent<Camera>().enabled = false;
        }
        else
        {
            camera.SetActive(false);
            maincamera.GetComponent<Camera>().enabled = true;
        }
    }
}

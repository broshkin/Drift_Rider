using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchPlayer : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var a = car.transform.position - gameObject.transform.position;
        Debug.DrawRay(transform.position, a + new Vector3(0, 10, 0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log('1');
            var a = collision.gameObject.transform.position - gameObject.transform.position;
            Debug.DrawRay(transform.position, a);
            collision.gameObject.GetComponentInParent<Rigidbody>().AddForce((a + new Vector3(0, 8, 0)) * 4000, ForceMode.Impulse);
        }
    }
}

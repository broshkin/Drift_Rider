using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointToEnemy : MonoBehaviour
{
    public GameObject arrow;
    public GameObject enemy;
    [Range(0, 100)]
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion _rot = Quaternion.LookRotation(enemy.transform.position - gameObject.transform.position);
        arrow.transform.rotation = Quaternion.Euler(0, Quaternion.Lerp(arrow.transform.rotation, _rot, speed * Time.deltaTime).eulerAngles.y, Quaternion.Lerp(arrow.transform.rotation, _rot, speed * Time.deltaTime).eulerAngles.z);
    }
}

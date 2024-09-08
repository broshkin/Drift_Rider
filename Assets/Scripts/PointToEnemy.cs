using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class PointToEnemy : MonoBehaviour
{
    public GameObject arrow;
    [Range(0, 100)]
    public float speed;
    private float minDistance = 10000;
    private float countOfLit;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        countOfLit = GameObject.FindGameObjectsWithTag("Box").Length;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var a = GameObject.FindGameObjectsWithTag("Box");
        var b = a.Select(x => Vector3.Distance(x.transform.position, transform.position)).ToList();
        target = a[b.IndexOf(b.Min())];
        Quaternion _rot = Quaternion.LookRotation(target.transform.position - gameObject.transform.position);
        arrow.transform.rotation = Quaternion.Euler(0, Quaternion.Lerp(arrow.transform.rotation, _rot, speed * Time.deltaTime).eulerAngles.y, Quaternion.Lerp(arrow.transform.rotation, _rot, speed * Time.deltaTime).eulerAngles.z);
    }
}

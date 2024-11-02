using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorScript : MonoBehaviour
{
    public GameObject point;
    public float speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, point.transform.position, speed * Time.deltaTime);
    }
}

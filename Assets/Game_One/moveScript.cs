using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScript : MonoBehaviour
{
    public GameObject point;
    public float speed;

    public GameObject[] block;

    private void Start()
    {
        if (gameObject == block[0])
        {
            Invoke("Boom", 7f);
        }
        else if (gameObject == block[1])
        {
            Invoke("Boom", 11f);
        }
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, point.transform.position, speed * Time.deltaTime);
    }

    void Boom()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missleScript : MonoBehaviour
{
    public GameObject point;
    public float speed;

    public GameObject fire;

    bool contact;

    private void Start()
    {
        Invoke("Boom", 5f);
    }
    void Update()
    {
        if (!contact)
        {
            transform.position = Vector3.MoveTowards(transform.position, point.transform.position, speed * Time.deltaTime);
        } else
        {
            transform.position = transform.position;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            contact = true;
            fire.SetActive(true);
            Destroy(other.gameObject);
            Invoke("smack", .05f);
        }
    }

    void smack()
    {
        Destroy(gameObject);
    }
    void Boom()
    {
        Destroy(gameObject);
    }
}

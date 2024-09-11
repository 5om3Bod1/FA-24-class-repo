using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetBoom : MonoBehaviour
{
    public int count;
    public GameObject group;
    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            group.SetActive(true);
            gameObject.transform.DetachChildren();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            count--;
        }
    }
}
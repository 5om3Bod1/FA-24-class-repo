using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetSplit : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            count--;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrain : MonoBehaviour
{
    public int count;
    public GameObject rock;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            count--;
            Debug.Log("Hi");
        }
    }
    private void Update()
    {
        if(count == 0)
        {
            rock.SetActive(false);
        }
    }
}

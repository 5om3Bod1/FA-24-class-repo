using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallOne : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = new Vector3(-7.5f, -3.5f, 0f);
            Debug.Log("Hit");
        }
    }
}

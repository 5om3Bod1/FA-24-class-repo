using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject player;
    public int num;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<playerRespawn>().respawnLocation();
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp("r"))
        {
            player.GetComponent<playerRespawn>().respawnLocation(); 
        }
    }
}

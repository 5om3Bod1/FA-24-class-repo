using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newReset : MonoBehaviour
{
    public GameObject entered;
    public GameObject enterd;

    private void Start()
    {
        enterd.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            entered.SetActive(true);
            enterd.SetActive(false);
            other.gameObject.GetComponent<playerRespawn>().respawnPoint = gameObject.transform;
        }
    }
}
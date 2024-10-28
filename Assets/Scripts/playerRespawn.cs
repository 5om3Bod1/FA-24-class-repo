using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    public Transform respawnPoint;

    public void respawnLocation()
    {
        StartCoroutine(controllerOff());
        transform.position = respawnPoint.position;
    }

    IEnumerator controllerOff()
    {
        gameObject.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(.1f);
        gameObject.GetComponent<CharacterController>().enabled = true;
    }
}
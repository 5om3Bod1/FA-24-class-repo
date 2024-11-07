using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public GameObject door;

    //From Tutorial
    public Transform newRoom;
    //
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //From Tutorial
            if (other.transform.position.x < transform.position.x)//
            {
                camLock.Instance.moveCamera(newRoom);
                door.SetActive(true);
                roomSpawner.Instance.callCaller();
            }
        }
    }
}

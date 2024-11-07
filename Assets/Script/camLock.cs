using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLock : MonoBehaviour
{
    //From Tutorial
    public float speed;
    private float currentPosX;
    private float currentPosY;
    private Vector3 velocity = Vector3.zero;
    //

    public static camLock Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        //From Tutorial
        transform.position = Vector3.SmoothDamp(transform.position, 
            new Vector3(currentPosX, currentPosY, transform.position.z), ref velocity, speed * Time.deltaTime);
        //
    }

    public void moveCamera(Transform newRoom)
    {
        Debug.Log("Hit");
        currentPosX = newRoom.position.x;
        currentPosY = newRoom.position.y;
    }
    //
}

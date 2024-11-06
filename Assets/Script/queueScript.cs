using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queueScript : MonoBehaviour
{
    public static Queue<GameObject> roomQueue = new Queue<GameObject>();
    public GameObject[] stopLight;
    public Vector2[] spawnSpot;

    public int roomAmount;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            Debug.Log("pressed");
            if(roomAmount < 4)
            {
                int var = Random.Range(0, 3);
                GameObject toSpawn = Instantiate(stopLight[var], spawnSpot[var], Quaternion.identity);
                roomQueue.Enqueue(toSpawn);
                roomAmount++;

                if(roomAmount == 4)
                {
                    GameObject toDestory = roomQueue.Dequeue();
                    Destroy(toDestory);
                    roomAmount--;
                    Debug.Log(roomQueue.Peek());
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSpawner_Door : MonoBehaviour
{
    public Transform connectingTransform;
    public GameObject deadEnd;
    public GameObject forceEnd_0;
    public GameObject forceEnd_1;
    public GameObject forceEnd_2;
    public GameObject forceEnd_3;
    public List<GameObject> roomList = new List<GameObject>();
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;

        if (DungeonSpawner.spawnedRooms.Count < 72)
        {
            //Second Gen
            if (DungeonSpawner.spawnedRooms.Count == 5)
            {
                roomList.Remove(forceEnd_0);
                roomList.Add(deadEnd);
            }
            //Third Gen
            else if (DungeonSpawner.spawnedRooms.Count >= 32)
            {
                
                roomList.Remove(forceEnd_1);
                roomList.Remove(forceEnd_2);
                roomList.Remove(forceEnd_3);
                roomList.Add(deadEnd);
                roomList.Add(deadEnd);
                roomList.Add(deadEnd);
            }

            int temp = Random.Range(0, roomList.Count);
            while (temp >= roomList.Count)
            {
                temp = Random.Range(0, roomList.Count);
            }

            GameObject tempRoom = Instantiate(roomList[temp]);
            tempRoom.transform.position = connectingTransform.position;

            foreach (Vector3 spawnedRoom in DungeonSpawner.spawnedRooms)
            {
                if (spawnedRoom == tempRoom.transform.localPosition)
                {
                    Destroy(tempRoom);
                    canSpawn = false;
                }
            }

            if (canSpawn == true)
            {
                DungeonSpawner.spawnedRooms.Add(tempRoom.transform.localPosition);
            }
        }
    }
}

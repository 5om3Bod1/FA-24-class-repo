using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSpawner : MonoBehaviour
{
    public Transform connectingTransform;
    public GameObject[] roomList;
    public int roomNum;

    public static doorSpawner Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        roomSpawner.Instance.roomGen.Enqueue(gameObject);

    }
    public void roomSpawn()
    {
        if (roomNum < 1)
        {
            int temp = Random.Range(0, roomList.Length);
            while (temp >= roomList.Length)
            {
                temp = Random.Range(0, roomList.Length);
            }
            GameObject tempRoom = Instantiate(roomList[temp]);
            tempRoom.transform.position = connectingTransform.position;
            roomNum++;
        }
    }
}

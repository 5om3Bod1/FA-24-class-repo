using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCondition : MonoBehaviour
{
    //Room Dice-Roller
    public GameObject[] doors;
    public static GameObject selectedDoor;
    public GameObject[] winCon;
    public GameObject[] roomLayout;
    public int doorNum;

    //Next Room Dice
    public int roomNum;
    public Transform[] connectingTransform;

    //Which direction its going
    public GameObject[] roomList;

    public static doorCondition Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        roomSpawner.Instance.roomGen.Enqueue(gameObject);
        roomGenerator();
    }

    public void roomGenerator()
    {
        //Select the location of the Wincon
        /*
        int winNum = Random.Range(0, 4);
        foreach (GameObject item in winCon)
        {
            if (item != winCon[winNum])
            {
                item.SetActive(false);
            }
            winCon[winNum].SetActive(true);
        }
        */

        //Select the roomLayout
        int roomNum = Random.Range(0, 4);
        foreach (GameObject item in roomLayout)
        {
            if (item != roomLayout[roomNum])
            {
                item.SetActive(false);
            }
            roomLayout[roomNum].SetActive(true);
        }
        
        //Select the location of the door
        doorNum = Random.Range(0, doors.Length);
        while (doorNum >= doors.Length)
        {
            doorNum = Random.Range(0, doors.Length);
        }
        foreach (GameObject item in doors)
        {
            if (item != doors[doorNum])
            {
                doors[doorNum].SetActive(true);
                item.SetActive(true);
            }
            //selectedDoor = doors[doorNum];
            doors[doorNum].SetActive(false);
        }
    }

    public void roomSpawn()
    {
        if (roomNum < 1)
        {
            GameObject tempRoom = Instantiate(roomList[doorNum]);
            tempRoom.transform.position = connectingTransform[doorNum].position;
            roomNum++;
        }
    }
}

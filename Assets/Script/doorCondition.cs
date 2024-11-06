using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCondition : MonoBehaviour
{

    public GameObject[] doors;
    public static GameObject selectedDoor;

    public GameObject[] winCon;

    public GameObject[] roomLayout;

    public static doorCondition IInstnace { get; private set; }

    private void Awake()
    {
        IInstnace = this;
    }

    public void roomGenerator()
    {
        //Select the location of the Wincon
        int winNum = Random.Range(0, 4);
        winCon[winNum].SetActive(true);

        //Select the location of the door
        int doorNum = Random.Range(0, 4);
        selectedDoor = doors[doorNum];

        //Select the roomLayout
        int roomNum = Random.Range(0, 4);
        roomLayout[roomNum].SetActive(true);
    }
}

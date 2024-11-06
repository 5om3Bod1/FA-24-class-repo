using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCondition : MonoBehaviour
{

    public GameObject[] doors;
    public static GameObject selectedDoor;
    public static int doorNum;

    public GameObject[] winCon;
    

    // Start is called before the first frame update
    void Start()
    {
        roomGenerator();
    }

    void roomGenerator()
    {
        //Select the location of the Wincon
        int winNum = Random.Range(0, 4);
        winCon[winNum].SetActive(true);

        //Select the location of the door
        doorNum = Random.Range(0, 4);
        selectedDoor = doors[doorNum];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawner : MonoBehaviour
{
    public GameObject starterRoom;
    public int roomAmount;

    public Queue<GameObject> roomGen = new Queue<GameObject>();

    public static roomSpawner Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Instantiate(starterRoom);
        roomAmount = 1;
        StartCoroutine(loopCall());
    }

    IEnumerator loopCall()
    {
        yield return new WaitForSeconds(1.7f);
        if(roomAmount < 3)
        {
            doorCondition.Instance.roomSpawn();
            roomAmount++;
            StartCoroutine(loopCall());
        }
    }

    public void callCaller()
    {
        GameObject toDestory = roomGen.Dequeue();
        Destroy(toDestory);
        roomAmount--;
        StartCoroutine(loopCall());
    }
}

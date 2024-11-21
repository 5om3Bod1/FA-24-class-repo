using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushSpawner : MonoBehaviour
{
    public GameObject[] mushRoom;
    public Queue<Vector3> spawnLocation = new Queue<Vector3>();
    public Vector3[] spawnLoc;
    public int val;
    public bool hot;

    private void Start()
    {
        hot = false;
        for(int var = 0; var < 12; var++)
        {
            spawnLocation.Enqueue(spawnLoc[var]);
            val++;
        }
        StartCoroutine(checkQue());
    }
    IEnumerator checkQue()
    {
        while (!hot)
        {
            yield return new WaitForSeconds(.5f);
            if(val == 12)
            {
                spawnMushroom();
                hot = true;
            }
        }
    }
    void spawnMushroom()
    {
        for (int mushAmount = 12; mushAmount > 0; mushAmount--)
        {
            Vector3 spore = spawnLocation.Peek();
            Instantiate(mushRoom[Random.Range(0, mushRoom.Length)], spore, Quaternion.identity);
            spawnLocation.Dequeue();
        }
    }
}

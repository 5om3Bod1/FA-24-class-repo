using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushSpawn : MonoBehaviour
{
    public GameObject[] mushRoom;
    public int radius;

    public int currentAmount;
    public int needAmount;

    private void Start()
    {
        StartCoroutine(areaSpawn());
    }

    IEnumerator areaSpawn()
    {
        yield return new WaitForSeconds(.5f);
        if(currentAmount < needAmount)
        {
            int mushNum = Random.Range(0, mushRoom.Length);
            float ranX = Random.Range(gameObject.transform.position.x - radius, gameObject.transform.position.x + radius);
            float ranZ = Random.Range(gameObject.transform.position.z - radius, gameObject.transform.position.z + radius);

            Vector3 spawnLoc = new Vector3(ranX, -.17f, ranZ);
            Instantiate(mushRoom[mushNum], spawnLoc, Quaternion.identity);
            currentAmount++;
            StartCoroutine(areaSpawn());
        }
        else if(currentAmount == needAmount)
        {
            StopCoroutine(areaSpawn());
        }
    }
}

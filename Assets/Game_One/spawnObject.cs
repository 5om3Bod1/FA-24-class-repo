using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    public GameObject[] prefab;

    void Start()
    {
        StartCoroutine(spawnFish());
    }

    IEnumerator spawnFish()
    {            
        yield return new WaitForSeconds(2f);
        int num = Random.Range(0, 4);
        if(num == 0 || num == 1)
        {
            Vector3 spawnZone = new Vector3(-13, Random.Range(4f, -5f), -.55f);
            Instantiate(prefab[num], spawnZone , Quaternion.identity);
        }
        else if(num == 2 || num == 3)
        {
            Vector3 spawnArea = new Vector3(13, Random.Range(4f, -5f), -.55f);
            Instantiate(prefab[num], spawnArea, Quaternion.identity);

        }
        StartCoroutine(spawnFish());
    }
}

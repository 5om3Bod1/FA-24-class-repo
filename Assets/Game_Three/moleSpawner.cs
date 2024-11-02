using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleSpawner : MonoBehaviour
{

    public GameObject[] moles;
    public int num;

    private void Start()
    {
        spawnMole();
    }
    void spawnMole()
    {
        num = Random.Range(0, 4);
        moles[num].SetActive(true);
    }
}

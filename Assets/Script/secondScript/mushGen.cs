using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushGen : MonoBehaviour
{
    public GameObject[] spawnLoc;
    public GameObject cresFall;
    public bool hasFall;

    private void Start()
    {
        int diceRoll_0 = Random.Range(0, 10+1);
        int diceRoll_1 = Random.Range(0, 5);
        int diceRoll_2 = Random.Range(0, 2+1);
        if (diceRoll_0 < 10)
        {
            spawnLoc[diceRoll_1].SetActive(true);
        }
        else if(diceRoll_0 == 10)
        {
            spawnLoc[0].SetActive(true);
            spawnLoc[1].SetActive(true);
            spawnLoc[2].SetActive(true);
            spawnLoc[3].SetActive(true);
        }
        if(diceRoll_2 == 2 && hasFall == true)
        {
            Invoke("fallSpawn", 210f);
        }
    }
    void fallSpawn()
    {
        cresFall.SetActive(true);
    }
}

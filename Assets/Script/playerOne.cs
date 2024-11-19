using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOne : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject[] units;

    public int unitAmount;

    public bool coolDown;
    public bool atMax;

    public static playerOne Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if(!coolDown && !atMax)
        {
            if (Input.GetKeyUp("q"))
            {
                GameObject blueUnit = Instantiate(units[0], spawnLocation.transform.position, Quaternion.identity);
                coolDown = true;
                unitAmount++;
                Invoke("offCooldown", 1.5f);
            }
            else if (Input.GetKeyUp("w"))
            {
                GameObject blueUnit = Instantiate(units[1], spawnLocation.transform.position, Quaternion.identity);
                coolDown = true;
                unitAmount++;
                Invoke("offCooldown", 1.5f);
            }
        }
        if (unitAmount == 6)
        {
            atMax = true;
        }
        else
        {
            atMax = false;
        }
    }
    void offCooldown()
    {
        coolDown = false;
    }
}

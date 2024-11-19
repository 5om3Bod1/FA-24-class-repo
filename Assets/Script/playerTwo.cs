using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwo : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject[] units;

    public int unitAmount;

    public bool cooldown;
    public bool atMax;

    public static playerTwo Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (!cooldown && !atMax)
        {
            if (Input.GetKeyUp("o"))
            {
                GameObject blueUnit = Instantiate(units[0], spawnLocation.transform.position, Quaternion.identity);
                cooldown = true;
                unitAmount++;
                Invoke("offCooldown", 1.5f);
            }
            else if (Input.GetKeyUp("p"))
            {
                GameObject blueUnit = Instantiate(units[1], spawnLocation.transform.position, Quaternion.identity);
                cooldown = true;
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
        cooldown = false;
    }
}

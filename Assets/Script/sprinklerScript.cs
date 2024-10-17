using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinklerScript : MonoBehaviour
{
    public barManager power;
    public GameObject barMgr;

    public bool water;
    private void Awake()
    {
        power = barMgr.GetComponent<barManager>();
    }
    private void OnMouseUp()
    {
        if (water)
        {
            //Not using power
            power.onPower = false;
            water = false;
            Debug.Log(water);
        }
        else
        {
            //Using power
            power.onPower = true;
            water = true;
            Debug.Log(water);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinklerScript : MonoBehaviour
{
    public barManager power;
    public GameObject barMgr;

    public bool ticked;
    private void Awake()
    {
        power = barMgr.GetComponent<barManager>();
    }
    private void OnMouseUp()
    {
        if (ticked)
        {
            power.onPower = false;
            ticked = false;
            Debug.Log(ticked);
        }
        else
        {
            power.onPower = true;
            ticked = true;
            Debug.Log(ticked);
        }
        
    }
}

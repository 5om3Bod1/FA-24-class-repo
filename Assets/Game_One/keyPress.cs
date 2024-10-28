using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class keyPress : MonoBehaviour
{
    public TMP_Text pointText;
    public int point;
    //Use ramp to increase diffculty with a dontdestoryonload script in the future
    //public int ramp;

    private void OnMouseExit()
    {
        point++;
    }
}

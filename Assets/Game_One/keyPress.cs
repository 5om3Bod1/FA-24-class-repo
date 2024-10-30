using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class keyPress : MonoBehaviour
{
    private void OnMouseExit()
    {
        pointState.IInstnace.increase();
    }
}

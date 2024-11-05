using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class keyPress : MonoBehaviour
{
    public GameObject[] states;
    private void OnMouseDown()
    {
        states[0].SetActive(false);
        states[1].SetActive(true);
        pointState.IInstnace.increase();
    }
    private void OnMouseUp()
    {
        states[0].SetActive(true);
        states[1].SetActive(false);
    }
}

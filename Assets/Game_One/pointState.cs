using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointState : MonoBehaviour
{
    public static pointState IInstnace { get; private set; }

    public TMP_Text pointText;
    public int point;
    //Use ramp to increase diffculty with a dontdestoryonload script in the future
    //public int ramp;

    private void Awake()
    {
        IInstnace = this;
    }
    void Start()
    {
        StartCoroutine(timer());
        StartCoroutine(numDrop());
    }

    IEnumerator timer()
    {
        pointText.text = point.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(timer());
    }
    IEnumerator numDrop()
    {
        //Change the point decrease value to ramp so like 3-> 4 -> 5(max)
        point-=3;
        yield return new WaitForSeconds(1);
        StartCoroutine(numDrop());
    }

    public void increase()
    {
        point++;
    }
}

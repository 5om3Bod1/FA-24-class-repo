using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class pointState : MonoBehaviour
{
    public TMP_Text pointText;
    public int point;
    //Use ramp to increase diffculty with a dontdestoryonload script in the future
    //public int ramp;

    private void Awake()
    {
        point = 20;
    }
    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        pointText.text = point.ToString();
        point--;
        yield return new WaitForSeconds(1);
        StartCoroutine(timer());
    }
}

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        StartCoroutine(numDrop());
    }
    private void Update()
    {
        pointText.text = point.ToString();
        if(point <= 0)
        {
            sceneSwap();
        }
    }
    IEnumerator numDrop()
    {
        //Change the point decrease value to ramp so like 3-> 4 -> 5(max)
        point-=5;
        yield return new WaitForSeconds(1);
        StartCoroutine(numDrop());
    }
    public void increase()
    {
        point++;
    }
    void sceneSwap()
    {
        int num = 1;
        gameStat.IInstnace.lifeVal--;
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour
{
    public static countDown IInstnace { get; private set; }

    public TMP_Text countD;
    public int timeLeft;
    public int lose;
    public int win;

    private void Awake()
    {
        IInstnace = this;
    }
    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        countD.text = timeLeft.ToString();
        Debug.Log(timeLeft);
        timeLeft--;
        if(timeLeft == -1 && winTrigger.IInstnace.win==false)
        {
            SceneManager.LoadScene(lose, LoadSceneMode.Single);
        }
        else if(winTrigger.IInstnace.win == true)
        {
            SceneManager.LoadScene(win, LoadSceneMode.Single);
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(timer());
    }
}

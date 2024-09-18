using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class breakScript : MonoBehaviour
{
    public int score;
    public int sceneNum;
    public TMP_Text scoreBoard;

    public AudioSource playOne;

    private void Start()
    {
        playOne.Play();
        Invoke("num", 1f);
        Invoke("num", 2f);
        Invoke("num1", 3f);
    }
    private void Update()
    {
        if (score == 0)
        {
            Debug.Log(sceneNum);
            SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
        }
    }
    void num()
    {
        score--;
        scoreBoard.text = score.ToString();
    }
    void num1()
    {
        sceneNum = Random.Range(1, 4);
        score--;
        scoreBoard.text = score.ToString();
    }
}

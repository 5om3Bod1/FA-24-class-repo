using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{
    public int count;
    public int score;
    public int sceneNum;
    public TMP_Text scoreBoard;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            score ++;
            scoreBoard.text = score.ToString();
        }
    }
    private void Update()
    {
        if(score == 3)
        {
            SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class newGame : MonoBehaviour
{
    public TMP_Text lifePoint;
    public GameObject lifeText;
    public int lifeTime;

    private void Start()
    {
        lifeTime = gameStat.IInstnace.lifeVal;
        lifeCheck();
    }


     void lifeCheck()
    {
        lifeText.SetActive(true);
        lifePoint.text = lifeTime.ToString();
        if (lifeTime == 0)
        {
            Invoke("gameOver", 1f);
        }
        else
        {
            Invoke("newGam", 3f);
        }
        Debug.Log(lifePoint);
    }    
    void newGam()
    {
        int num = Random.Range(3, 6);
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
    void gameOver()
    {
        int num = 2;
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}

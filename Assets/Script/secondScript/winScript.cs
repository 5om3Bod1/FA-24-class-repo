using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour
{
    public GameObject pressKey;
    public GameObject obj;

    public GameObject gameResult;

    public GameObject[] results;
    public int totalAmount;

    public GameObject next;
    bool wait;
    bool done;

    private void Start()
    {
        Invoke("popUp", 2f);
        
    }
    void popUp()
    {
        pressKey.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyUp("space") && !wait)
        {
            obj.SetActive(false);
            gameResult.SetActive(true);
            Invoke("finalReveal", 6f);
            wait = true;
            Invoke("show", 7f);
        }
        else if (Input.GetKeyUp("space") && done)
        {
            int num = 5;
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
    void finalReveal()
    {
        gameResult.SetActive(false);
        totalAmount = amountHolder.Instance.crimsonCount + amountHolder.Instance.deathCount + amountHolder.Instance.hornCount + amountHolder.Instance.fallCount;
        if(totalAmount >= 10)
        {
            //You win
            results[0].SetActive(true);
            done = true;
        }
        else if(totalAmount < 10)
        {
            //You lose, Starve
            results[1].SetActive(true);
            done = true;
        }
        else if(amountHolder.Instance.poisonCount >= 15)
        {
            //You lose, Poison
            results[2].SetActive(true);
            done = true;
        }
    }
    void show()
    {
        next.SetActive(true);
    }
}

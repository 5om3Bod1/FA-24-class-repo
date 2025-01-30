using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class newSafe : MonoBehaviour
{
    public bool safe;
    public int num;

    gameManager gameMan;
    public GameObject gameMange;
    private void Awake()
    {
        gameMan = gameMange.GetComponent<gameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            safe = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            safe = false;
        }
    }
    private void Update()
    {
        if (gameMan.gameTime == true && safe == true)
        {
            //Safe
            num = 2;
            sceneSwap();
        }
        else if (gameMan.gameTime == true && safe == false)
        {
            //!Safe
            num = 3;
            sceneSwap();
        }
    }
    void sceneSwap()
    {
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}

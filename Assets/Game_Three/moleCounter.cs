using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moleCounter : MonoBehaviour
{
    public int val = 5;

    public static moleCounter IInstnace { get; private set; }

    private void Awake()
    {
        IInstnace = this;
    }
    private void Start()
    {
        Invoke("sceneSwap", 15f);
    }
    private void Update()
    {
        if (val == 0)
        {
            gameStat.IInstnace.lifeVal--;
            int num = 1;
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
    void sceneSwap()
    {
        int num = 1;
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}

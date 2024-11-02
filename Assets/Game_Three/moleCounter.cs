using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moleCounter : MonoBehaviour
{
    public int num;

    public static moleCounter IInstnace { get; private set; }

    private void Awake()
    {
        IInstnace = this;
    }

    private void Update()
    {
        if (num == 5)
        {
            Debug.Log("Game Over");
            //SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
}

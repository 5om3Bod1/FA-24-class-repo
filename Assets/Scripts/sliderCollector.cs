using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sliderCollector : MonoBehaviour
{
    public Slider[] slider;

    public int num;
    public bool game;

    public static sliderCollector IInstnace { get; private set; }

    private void Awake()
    {
        IInstnace = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        if (!game)
        {
            if (Input.GetKeyUp("space"))
            {
                game = true;
                SceneManager.LoadScene(num, LoadSceneMode.Single);
            }
        }
    }
}

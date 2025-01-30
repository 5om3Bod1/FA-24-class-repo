using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class amountHolder : MonoBehaviour
{
    public int crimsonCount;
    public int deathCount;
    public int hornCount;
    public int fallCount;
    public int poisonCount;

    public GameObject personalLight;

    public static amountHolder Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if(fallCount > 0)
        {
            personalLight.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameStat : MonoBehaviour
{
    public static gameStat IInstnace { get; private set; }

    public int lifeVal;

    public int num;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        IInstnace = this;
    }
}

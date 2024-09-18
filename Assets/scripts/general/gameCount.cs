using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCount : MonoBehaviour
{
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        count++;
        Debug.Log(count);
    }
}

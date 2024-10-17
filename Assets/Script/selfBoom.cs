using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfBoom : MonoBehaviour
{
    
    void Start()
    {
        Invoke("boom", 2f);
    }
    void boom()
    {
        Destroy(gameObject);
    }
}

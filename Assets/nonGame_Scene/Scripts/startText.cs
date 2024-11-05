using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startText : MonoBehaviour
{
    public GameObject text;

    private void Start()
    {
        text.SetActive(true);
        Invoke("off", 1f);
    }
    void off()
    {
        text.SetActive(false);
    }
}

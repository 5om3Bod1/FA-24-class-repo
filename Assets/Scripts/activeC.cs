using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeC : MonoBehaviour
{
    public GameObject canvas;

    void Awake()
    {
        canvas.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            canvas.SetActive(false);
        }
    }
}

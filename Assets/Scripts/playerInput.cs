using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    GameObject compGen;

    public GameObject[] objList;

    public int num;

    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("w"))
        {
            compGen.SetActive(true);

        }
        else if (Input.GetKeyUp("s"))
        {
            compGen.SetActive(true);

        }
    }
}

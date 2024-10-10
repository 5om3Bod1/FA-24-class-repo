using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    public GameObject compGen;
    public GameObject keyCheck;
    public bool choice;

    // Start is called before the first frame update
    void Start()
    {
        keyCheck.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Only can clicks on key and its locked in
        if (!choice)
        {
            if (Input.GetKeyUp("w"))
            {
                compGen.SetActive(true);
                choice = true;
            }
            else if (Input.GetKeyUp("s"))
            {
                //compGen
                compGen.SetActive(true);
                choice = true;
            }
        }
    }
}

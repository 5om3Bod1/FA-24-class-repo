using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            doorCondition.roomGenerator();
        }
    }
}

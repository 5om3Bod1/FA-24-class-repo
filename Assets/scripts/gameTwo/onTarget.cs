using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTarget : MonoBehaviour
{
    public int count;

    private void OnMouseExit()
    {
        //Makes sure player keeps mouse on the target
        count++;
    }
}

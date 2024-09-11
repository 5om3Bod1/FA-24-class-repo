using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offTarget : MonoBehaviour
{
    public int count;

    private void OnMouseOver()
    {
        //Makes sure player keeps mouse off the target
        count++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickScript : MonoBehaviour
{
    public int count;

    private void OnMouseEnter()
    {
        count++;
    }
}

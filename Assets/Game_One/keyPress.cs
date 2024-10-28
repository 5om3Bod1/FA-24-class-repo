using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyPress : MonoBehaviour
{

    public int point;


    private void OnMouseExit()
    {
        point++;
    }
}

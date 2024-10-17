using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ripeTomato : MonoBehaviour
{
    public tomatoGrowth tomatoSize;
    public GameObject tomatoG;

    private void Awake()
    {
        tomatoSize = tomatoG.GetComponent<tomatoGrowth>();
    }

    private void OnMouseUp()
    {
        tomatoSize.sizeCheck();
    }
}

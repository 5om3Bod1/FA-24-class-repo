using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revealScript : MonoBehaviour
{
    public GameObject[] results;
    private int val;

    private void Start()
    {
        val = 4;
        StartCoroutine(showRes());
    }
    IEnumerator showRes()
    {
        yield return new WaitForSeconds(1f);
        if (val >= 0)
        {
            results[val].SetActive(true);
            val--;
            StartCoroutine(showRes());
        }
        else
        {
            StopCoroutine(showRes());
        }
        
    }
}

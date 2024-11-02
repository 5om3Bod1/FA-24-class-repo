using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleGen : MonoBehaviour
{
    public GameObject[] mole;
    public int moleNum;

    private void Start()
    {
        StartCoroutine(numChanger());
    }

    IEnumerator numChanger()
    {        
        for(moleNum = 0; moleNum <= 5; moleNum++)
        {
            mole[moleNum].SetActive(true);
            Debug.Log(moleNum);
            yield return new WaitForSeconds(.5f);
        }
    }
}

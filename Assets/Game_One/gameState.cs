using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameState : MonoBehaviour
{
    //5 hitboxes
    public GameObject[] hitBox;

    public int showBox;

    private void Awake()
    {
        
    }
    void Start()
    {
        StartCoroutine(appearBox());
    }
    void stateChange()
    {          
        showBox = Random.Range(0, 5);
        foreach (GameObject item in hitBox)
        {
            if (item != hitBox[showBox])
            {
                item.SetActive(false);
            }
            hitBox[showBox].SetActive(true);
        }
    }

    IEnumerator appearBox()
    {
        stateChange();
        Debug.Log(showBox);
        yield return new WaitForSeconds(3f);
        StartCoroutine(appearBox());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameState : MonoBehaviour
{
    //5 hitboxes
    public GameObject[] hitbox;

    public int showBox;

    private void Awake()
    {
        
    }
    void Start()
    {
        showBox = Random.Range(0, 5);
        stateChange();
        StartCoroutine(appearBox());
    }
    void stateChange()
    {          
        if(showBox == 0)
        {
            hitbox[0].SetActive(true);
            hitbox[1].SetActive(false);
            hitbox[2].SetActive(false);
            hitbox[3].SetActive(false);
            hitbox[4].SetActive(false);
        } else if (showBox == 1)
        {
            hitbox[0].SetActive(false);
            hitbox[1].SetActive(true);
            hitbox[2].SetActive(false);
            hitbox[3].SetActive(false);
            hitbox[4].SetActive(false);
        } else if (showBox == 2)
        {
            hitbox[0].SetActive(false);
            hitbox[1].SetActive(false);
            hitbox[2].SetActive(true);
            hitbox[3].SetActive(false);
            hitbox[4].SetActive(false);

        } else if (showBox == 3)
        {
            hitbox[0].SetActive(false);
            hitbox[1].SetActive(false);
            hitbox[2].SetActive(false);
            hitbox[3].SetActive(true);
            hitbox[4].SetActive(false);
        } else if (showBox == 4)
        {
            hitbox[0].SetActive(false);
            hitbox[1].SetActive(false);
            hitbox[2].SetActive(false);
            hitbox[3].SetActive(false);
            hitbox[4].SetActive(true);
        }
    }

    IEnumerator appearBox()
    {
        Debug.Log(showBox);
        yield return new WaitForSeconds(3f);
        showBox = Random.Range(0, 5);
        stateChange();
        StartCoroutine(appearBox());
    }
}

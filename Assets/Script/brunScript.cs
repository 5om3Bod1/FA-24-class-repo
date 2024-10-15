using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brunScript : MonoBehaviour
{
    public GameObject[] boxes;
    private bool inside;
    public int count;

    public bool onFire;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = true;
            StartCoroutine(RoastTest());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = false;
        }
    }

    private void Update()
    {
        Debug.Log(inside);
        Debug.Log(count);
        if (count == 10)
        {
            //Medium
            boxes[0].SetActive(false);
            boxes[1].SetActive(true);
        }
        else if (count == 15)
        {
            //Roast
            boxes[1].SetActive(false);
            boxes[2].SetActive(true);
        }
        else if (count == 20)
        {
            //Burnt
            boxes[2].SetActive(false);
            boxes[3].SetActive(true);
        }
        else if (count >= 25)
        {
            //Burnt
            boxes[4].SetActive(true);
            onFire = true;
        }
    }

    IEnumerator RoastTest()
    {
        while (inside)
        {
            count++;
            Debug.Log(count);
            yield return new WaitForSeconds(1);
        }
    }
}

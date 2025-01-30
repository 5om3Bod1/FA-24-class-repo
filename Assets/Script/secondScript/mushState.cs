using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushState : MonoBehaviour
{
    public bool onMushroom;
    private GameObject progressBar;

    private void Start()
    {
        progressBar = gameManager.Instance.progBar;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            onMushroom = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            onMushroom = false;
        }
    }
    private void Update()
    {
        if (onMushroom == true && Input.GetKeyUp("e"))
        {
            progressBar.SetActive(true);
            Invoke("removeMush",1f);
        }
    }
    void removeMush()
    {
        progressBar.SetActive(false);
        if(gameObject.tag == "Crimson")
            {
                amountHolder.Instance.crimsonCount++;
            }
        else if (gameObject.tag == "Death")
            {
                amountHolder.Instance.deathCount++;
            }
        else if (gameObject.tag == "Horn")
            {
                amountHolder.Instance.hornCount++;
            }
        else if (gameObject.tag == "Fall")
            {
                amountHolder.Instance.fallCount++;
            }
        else if (gameObject.tag == "Poison")
        {
            amountHolder.Instance.poisonCount++;
        }
        Destroy(gameObject);
    }
}

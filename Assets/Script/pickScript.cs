using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickScript : MonoBehaviour
{
    public int pickTime;
    public bool picking;
    private void Start()
    {
        if(gameObject.tag == "Big")
        {
            pickTime = 3;
        }
        else if (gameObject.tag == "Mid")
        {
            pickTime = 5;
        }
        else if (gameObject.tag == "Small")
        {
            pickTime = 7;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(pickTimer());
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            picking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            picking = false;
            StopCoroutine(pickTimer());
        }
    }
    IEnumerator pickTimer()
    {
        yield return new WaitForSeconds(1);
        if (picking)
        {
            pickTime--;
            if(pickTime == -1)
            {
                if (gameObject.tag == "Big")
                {
                    mushroomManager.Instance.mushroomPoints++;
                }
                else if (gameObject.tag == "Mid")
                {
                    mushroomManager.Instance.mushroomPoints+=3;
                }
                else if (gameObject.tag == "Small")
                {
                    mushroomManager.Instance.mushroomPoints+=5;
                }
                gameObject.SetActive(false);
                StopCoroutine(pickTimer());
            }
            else
            {
                StartCoroutine(pickTimer());
            }
        }
    }

}

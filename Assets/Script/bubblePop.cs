using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblePop : MonoBehaviour
{
    public AudioSource playOne;


    //Used to remove the bubble after a set amount of time to avoid over crowding
    private void Start()
    {
        Invoke("gone", 2f);
    }
    void gone()
    {
        Destroy(gameObject);
    }


    private void OnMouseDown()
    {
        playOne.Play();
        Destroy(gameObject,.2f);
    }
}

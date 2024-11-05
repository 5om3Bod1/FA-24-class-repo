using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHigh : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moleCounter.IInstnace.val--;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            moleCounter.IInstnace.val++;
        }
    }
}

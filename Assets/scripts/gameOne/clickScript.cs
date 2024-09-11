using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickScript : MonoBehaviour
{
    public int count;

    private void OnMouseOver()
    {
        count++;
    }

    //Note to future self
    //Make it so after some seconds then the exit shows to prevent cheating if I can't figure a way how to spawn the mouse in the middle.

    //Maybe Note
    //Have it so the destination just bounces around the whole screen but invisible as the empty chases it.
}

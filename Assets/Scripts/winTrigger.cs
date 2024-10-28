using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public bool win;

    public static winTrigger IInstnace { get; private set; }

    private void Awake()
    {
        IInstnace = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            win = true;
        }
    }
}

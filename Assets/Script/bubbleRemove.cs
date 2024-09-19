using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleRemove : MonoBehaviour
{
    private void Start()
    {
        Invoke("gone", 5f);
    }
    void gone()
    {
        Destroy(gameObject);
    }
}

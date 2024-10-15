using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkin : MonoBehaviour
{
    public Transform hostParent;
    public bool attach;
    public GameObject pump;

    private void OnMouseUpAsButton()
    {
        if(!attach)
        {
            pump.GetComponent<MeshCollider>().enabled = false;
            transform.SetParent(hostParent);
            attach = true;
            Invoke("stick", .5f);
        }
    }
    void stick()
    {
        pump.transform.position = new Vector3(0.5f, -0.4f, 1.5f);
    }
}

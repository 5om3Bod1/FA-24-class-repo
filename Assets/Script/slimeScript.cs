using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeScript : MonoBehaviour
{
    public bool plate;

    public GameObject[] plateState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (!plate)
        {
            //Down
            plateState[1].SetActive(false);
            plateState[0].SetActive(true);
            gameObject.transform.position = new Vector3(4f, 1.03f, 0f);
            plate = true;
        }
        else if(plate)
        {
            //Up
            plateState[0].SetActive(false);
            plateState[1].SetActive(true);
            gameObject.transform.position = new Vector3(0f, -.325f, 0f);
            plate = false;
        }
    }
}

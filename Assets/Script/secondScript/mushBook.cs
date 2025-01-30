using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushBook : MonoBehaviour
{
    public Transform finalLocation;
    public Transform initialLocation;
    public float speed;
    bool pressed;

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            if (!pressed)
            {
                pressed = true;
            }
            else if (pressed)
            {
                pressed = false;
            }
        }

        if (pressed)
        {
            transform.position = Vector3.MoveTowards(transform.position, finalLocation.transform.position, speed * Time.deltaTime);
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, initialLocation.transform.position, speed * Time.deltaTime);
        }
    }
}

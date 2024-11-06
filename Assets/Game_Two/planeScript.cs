using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{
    public float speed;
    Vector3 target;
    private Camera cam;
    public GameObject missle;
    public GameObject launch;
    bool coolDown;

    // Start is called before the first frame update
    void Start()
    {
        //From tutorial on how to move object to mouse and I modified it so the plan can only move side to side
        cam = Camera.main;
        target = transform.position;
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {        
            if (!coolDown)
            {
                Vector3 launchP = launch.transform.position;
                Instantiate(missle,launchP, Quaternion.identity);
                coolDown = true;
                Invoke("onCooldown",.3f);
            }
        }

        //From a tutorial 
        target = cam.ScreenToWorldPoint(Input.mousePosition);
        target.y = transform.position.y;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //
    }

    void onCooldown()
    {
        coolDown = false;
    }
}

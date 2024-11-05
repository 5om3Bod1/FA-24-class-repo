using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleScript : MonoBehaviour
{
    public GameObject upward;
    public GameObject downward;
    public GameObject[] bonk;

    public float speed;

    public bool hit;

    private void Update()
    {
        if (!hit)
        {
            bonk[0].SetActive(true);
            bonk[1].SetActive(false);
            transform.position = Vector3.MoveTowards(transform.position, upward.transform.position, speed * Time.deltaTime);
        }
        else if (hit)
        {
            bonk[0].SetActive(false);
            bonk[1].SetActive(true);
            speed = 3;
            transform.position = Vector3.MoveTowards(transform.position, downward.transform.position, speed * Time.deltaTime);
        }        
    }
    private void OnMouseUp()
    {
        hit = true;
        int num = Random.Range(1, 3);
        //Ramp changes the speed they come back
        Invoke("upwards", num);
    }
    void upwards()
    {
        hit = false;
        speed = 2;
    }
}

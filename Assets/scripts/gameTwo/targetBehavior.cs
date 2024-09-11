using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetBehavior : MonoBehaviour
{
    //Target Stats
    public GameObject point;
    public float speed;

    public GameObject lockIn;
    public GameObject lockOut;


    public bool move;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("sceneSwap", 10f);
        Invoke("numGen", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //From YT video, I have a similar script to this from an old project but it wasn't working so i got one off yt that works
        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, point.transform.position, speed * Time.deltaTime);
        }
        

        if (num == 1)
        {
            Debug.Log(num);
            lockOut.SetActive(false);
            lockIn.SetActive(true);
            Invoke("swap", 3f);
        }
        if (num == 2)
        {
            Debug.Log(num);
            lockIn.SetActive(false);
            lockOut.SetActive(true);
            Invoke("swip", 3f);
        }


    }
    void numGen()
    {
        num = Random.Range(1, 3);
        move = true;
        Debug.Log(num);
    }
    void swap()
    {
        num = 2;
    }
    void swip()
    {
        num = 1;
    }
    void sceneSwap()
    {
        //Invsert Sceneswitch syntax
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class gameState : MonoBehaviour
{
    public Queue<GameObject> blueQ = new Queue<GameObject>();
    public Queue<GameObject> redQ = new Queue<GameObject>();

    public int blueHP;
    public int redHP;
    public Transform blueLocation;
    public Transform redLocation;

    public static gameState Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        blueHP = 30;
        redHP = 30;
    }

    //When value = 0 then remove from queue and destory it
    private void Update()
    {
        if (blueHP <= 0)
        {
            GameObject toDestory = blueQ.Dequeue();
            Destroy(toDestory);
            playerOne.Instance.unitAmount--;
            blueHP = 30;
        }

        if (redHP <= 0)
        {
            GameObject toDestory = redQ.Dequeue();
            Destroy(toDestory);
            playerTwo.Instance.unitAmount--;
            redHP = 30;
        }
    }
}

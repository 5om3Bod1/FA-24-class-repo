using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomManager : MonoBehaviour
{
    //public Queue<int> mushroomPoints = new Queue<int>();
    public int mushroomPoints;

    public static mushroomManager Instance { get; private set; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            /*foreach(int mushroomPoints in mushroomPoints)
            {
                Debug.Log(mushroomPoints);
            }
            */
            Debug.Log(mushroomPoints);
        }
    }
}

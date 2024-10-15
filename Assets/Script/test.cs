using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    brunScript burn;
    [SerializeField] GameObject tree;

    public bool fireCheck;

    public GameObject[] boxes;

    private void Awake()
    {
        burn = tree.GetComponent<brunScript>();
    }
    private void Update()
    {
        fireCheck = burn.onFire;
        Debug.Log(fireCheck);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && fireCheck)
        {
            boxes[0].SetActive(true);
            boxes[1].SetActive(true);
            boxes[2].SetActive(true);
            boxes[3].SetActive(true);
            boxes[4].SetActive(true);
            boxes[5].SetActive(true);
            boxes[6].SetActive(true);
            boxes[7].SetActive(true);
            boxes[8].SetActive(true);
            boxes[9].SetActive(true);
            boxes[10].SetActive(true);
        }
    }
}

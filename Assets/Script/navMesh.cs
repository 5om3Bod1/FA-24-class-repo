using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMesh : MonoBehaviour
{
    public Transform[] finalDest;
    private NavMeshAgent _agent;

    public slimeScript slimeS;
    public GameObject slimeC;

    public int val;

    private void Awake()
    {
        slimeS = slimeC.GetComponent<slimeScript>();
    }

    void Start()
    {
        _agent.GetComponent<NavMeshAgent>();
        StartCoroutine(moveAbout());
    }

    IEnumerator moveAbout()
    {
        yield return new WaitForSeconds(1f);
        if (!slimeS.plate)
        {
            yield return new WaitForSeconds(4f);
            val = Random.Range(0, 3);
            if(val == 0)
            {
                _agent.destination = finalDest[0].position;
            }
            if (val == 1)
            {
                _agent.destination = finalDest[1].position;
            }
            if (val == 2)
            {
                _agent.destination = finalDest[2].position;
            }
            StartCoroutine(moveAbout());
        }
        else
        {
            StartCoroutine(moveAbout());
        }
        
    }
}

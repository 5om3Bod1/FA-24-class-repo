using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpawner : MonoBehaviour
{
    public GameObject[] form;
    int num;
    public GameObject[] meteor;

    void Start()
    {        
        num = Random.Range(0, 3);
        Instantiate(form[num]);
        Invoke("shower", 3f);
    }
    void shower()
    {
        StartCoroutine(showerTime());
    }
    IEnumerator showerTime()
    {
        yield return new WaitForSeconds(.5f);
        int val = Random.Range(0, 2);
        Vector3 randompawnPosition = new Vector3(Random.Range(-7f, 8f), 7f, -.7f);
        Instantiate(meteor[val], randompawnPosition, Quaternion.identity);
        StartCoroutine(showerTime());
    }
}

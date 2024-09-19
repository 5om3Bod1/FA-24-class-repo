using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleGen : MonoBehaviour
{
    //Audio
    public AudioSource playOne;

    //Num Gen
    public int var;

    //Bubble Colors
    public GameObject blueL;
    public GameObject blueM;
    public GameObject blueS;
    public GameObject yellowL;
    public GameObject yellowM;
    public GameObject yellowS;
    public GameObject redL;
    public GameObject redM;
    public GameObject redS;
    public GameObject greenL;
    public GameObject greenM;
    public GameObject greenS;
    public GameObject purpleL;
    public GameObject purpleM;
    public GameObject purpleS;
    public GameObject orangeL;
    public GameObject orangeM;
    public GameObject orangeS;


    private void Start()
    {
        playOne.Play();
        StartCoroutine(myCounter());
    }
    void Update()
    {
    }
    private IEnumerator myCounter()
    {
        var = Random.Range(1, 19);
        if (var == 1)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(blueL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 2)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(blueM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 3)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(blueS, randompawnPosition, Quaternion.identity);
        }
        else if (var == 4)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(yellowL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 5)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(yellowM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 6)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(yellowS, randompawnPosition, Quaternion.identity);
        }
        else if (var == 7)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(redL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 8)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(redM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 9)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(redS, randompawnPosition, Quaternion.identity);
        }
        else if (var == 10)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(greenL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 11)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(greenM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 12)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(greenS, randompawnPosition, Quaternion.identity);
        }
        else if (var == 13)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(purpleL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 14)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(purpleM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 15)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(purpleS, randompawnPosition, Quaternion.identity);
        }
        else if (var == 16)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(orangeL, randompawnPosition, Quaternion.identity);
        }
        else if (var == 17)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(orangeM, randompawnPosition, Quaternion.identity);
        }
        else if (var == 18)
        {
            Vector2 randompawnPosition = new Vector2(Random.Range(-1.75f, 1.75f), -1f);
            Instantiate(orangeS, randompawnPosition, Quaternion.identity);
        }
        yield return new WaitForSeconds(.25f);
        StartCoroutine(myCounter());
    }
}

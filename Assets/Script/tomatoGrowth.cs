using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatoGrowth : MonoBehaviour
{
    public GameObject[] tomatoStage;
    public float tomatoInt;

    //External
    public bool water;

    public barManager voidHunger;
    public GameObject barMgr;

    public sprinklerScript sprinkler;
    public GameObject sprink;

    public GameObject tomatoFall;

    private void Awake()
    {
        voidHunger = barMgr.GetComponent<barManager>();
        sprinkler = sprink.GetComponent<sprinklerScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(tomatoGrow());
        tomatoStage[1].SetActive(false);
        tomatoStage[2].SetActive(false);
        tomatoStage[0].SetActive(true);
    }

    private IEnumerator tomatoGrow()
    {
        yield return new WaitForSeconds(1f);
        if (sprinkler.water)
        {
            tomatoInt++;
            if(tomatoInt == 10)
            {
                tomatoStage[0].SetActive(false);
                tomatoStage[1].SetActive(true);
            }
            else if(tomatoInt == 20)
            {
                tomatoStage[1].SetActive(false);
                tomatoStage[2].SetActive(true);
            }
            StartCoroutine(tomatoGrow());
        }
        else
        {
            StartCoroutine(tomatoGrow());
        }
    }
    public void sizeCheck()
    {
        StartCoroutine(spawnTomato());
        tomatoInt = 0;
        tomatoStage[1].SetActive(false);
        tomatoStage[2].SetActive(false);
        tomatoStage[0].SetActive(true);
        Invoke("bonk", 1.5f);
    }
    IEnumerator spawnTomato()
    {
        yield return new WaitForSeconds(.5f);
        Instantiate(tomatoFall, new Vector3(-5f, 2f, -4.5f), Quaternion.identity);

    }

    void bonk()
    {
        voidHunger.voidH.value += 10;
    }
}

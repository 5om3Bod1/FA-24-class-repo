using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerGen : MonoBehaviour
{
    public int num;

    public GameObject[] objList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameRounds());
    }

    private IEnumerator GameRounds()
    {
        objList[0].SetActive(true);

        yield return new WaitForSeconds(.5f);
        Debug.Log(num);
        numCheck();
    }
    void numCheck()
    {
        if (num == 0)
        {
            objList[0].SetActive(false);
            objList[1].SetActive(true);
        }
        else if (num == 1)
        {
            objList[0].SetActive(false);
            objList[2].SetActive(true);
        }
    }
}

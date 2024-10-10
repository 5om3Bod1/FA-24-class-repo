using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerGen : MonoBehaviour
{
    public int num;
    public GameObject[] objList;
    public GameObject idle1;
    public GameObject idle2;

    void Start()
    {
        StartCoroutine(GameRounds());
    }

    private IEnumerator GameRounds()
    {
        num = Random.Range(0, 2);
        Debug.Log(num);

        //Turn off Idle Slime
        idle2.SetActive(false);

        //chargeJump
        objList[0].SetActive(true);

        //Turn off Idle Otter
        idle1.SetActive(false);

        //chargeAttack
        objList[1].SetActive(true);
        yield return new WaitForSeconds(.5f);
        numCheck();
    }
    void numCheck()
    {
        if (num == 0)
        {
            //highJump
            objList[0].SetActive(false);
            objList[1].SetActive(false);
            objList[2].SetActive(true);
        }
        else if (num == 1)
        {
            //noJump
            objList[0].SetActive(false);
            objList[1].SetActive(false);
            objList[3].SetActive(true);
        }
    }
}

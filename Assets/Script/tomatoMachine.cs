using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Events;

public enum tomatoState
{
    infant,
    teen,
    adult,
}
public class tomatoMachine : MonoBehaviour
{
    //Internal
    public tomatoState state;
    public float infantState, teenState, adultState;
    public GameObject[] tomato;

    //External
    public bool water;

    public barManager voidHunger;
    public GameObject barMgr;

    private void Awake()
    {
        voidHunger = barMgr.GetComponent<barManager>();
    }

    void Start()
    {
        StartCoroutine(infantWater());
    }

    #region Update Growth Behavior
    void Update()
    {
        switch (state)
        {
            case tomatoState.infant:
                infantState = 0;
                tomato[1].SetActive(false);
                tomato[2].SetActive(false);
                tomato[0].SetActive(true);
                break;

            case tomatoState.teen:
                teenState = 0;
                StartCoroutine(teenWater(0f));
                tomato[0].SetActive(false);
                tomato[1].SetActive(true);
                break;

            case tomatoState.adult:
                tomato[1].SetActive(false);
                tomato[2].SetActive(true);
                break;
            default:
                break;
        }
    }

    #endregion

    #region Growth State Change
    IEnumerator infantWater()
    {
        yield return new WaitForSeconds(1f);
        if (water)
        {
            infantState++;
            Debug.Log(infantState);
            StartCoroutine(infantWater());
        }
        else if (infantState == 10)
        {
            state = tomatoState.teen;
        }
        else
        {
            Debug.Log("Not Working");
            
            StartCoroutine(infantWater());
        }
    }

    IEnumerator teenWater(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (water)
        {
            teenState++;
            StartCoroutine(teenWater(1f));
        }
        else if (teenState == 10)
        {
            state = tomatoState.adult;
        }
        else
        {
            StartCoroutine(teenWater(.5f));
        }
    }

    private void OnMouseUp()
    {
        if (state == tomatoState.adult)
        {
            voidHunger.voidH.value+=15;
            state = tomatoState.infant;
            
        }
        else
        {
            voidHunger.voidH.value+=5;
            state = tomatoState.infant;
            
        }
    }
    #endregion
}


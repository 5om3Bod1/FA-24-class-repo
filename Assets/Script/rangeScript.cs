using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeScript : MonoBehaviour
{
    moveScript moveUnit;
    [SerializeField] GameObject moveObj;
    public bool rangeBlock;
    public GameObject rangeSlime;

    public static rangeScript Instance { get; private set; }

    void Awake()
    {
        Instance = this;
        moveUnit = moveObj.GetComponent<moveScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != gameObject.tag && moveUnit.enemyBlock == false)
        {
            rangeBlock = true;
            StartCoroutine(Attack());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "blueTeam" || collision.tag == "redTeam")
        {
            rangeBlock = false;
            if (gameObject.tag == "blueTeam")
            {
                rangeSlime.GetComponent<Animator>().Play("range_Idle");
            }
            else if (gameObject.tag == "redTeam")
            {
                rangeSlime.GetComponent<Animator>().Play("red_Idle");
            }
        }
    }

    IEnumerator Attack()
    {
        while (rangeBlock == true)
        {
            yield return new WaitForSeconds(1f);
            if (gameState.Instance.redHP > 0 && gameObject.tag == "blueTeam")
            {
                rangeSlime.GetComponent<Animator>().Play("range_Animation");
                int smack = Random.Range(0, 11);
                if (smack < 10)
                {
                    hitRed();
                }
                else
                {
                    hitMiss();
                }
            }
            if (gameState.Instance.blueHP > 0 && gameObject.tag == "redTeam")
            {
                rangeSlime.GetComponent<Animator>().Play("red_Animation");
                int smack = Random.Range(0, 11);
                if (smack < 10)
                {
                    hitBlue();
                }
                else
                {
                    hitMiss();
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }
    void hitRed()
    {
        //Instantiate(megaApple, appleSpawn);
        gameState.Instance.redHP -= 3;
    }
    void hitBlue()
    {
        //Instantiate(megaApple, appleSpawn);
        gameState.Instance.blueHP -= 3;
    }

    //Maybe add small flavor text saying "Miss" like in tft
    void hitMiss()
    {
        Debug.Log("Miss");
    }

}

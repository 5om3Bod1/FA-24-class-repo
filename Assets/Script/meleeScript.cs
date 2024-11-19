using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeScript : MonoBehaviour
{
    public bool blocked;
    public int speed;
    Vector2 enemySpawn;

    public static meleeScript Instance { get; private set; }

    void Start()
    {
        Instance = this;
        blocked = false;
        if(gameObject.tag == "blueTeam")
        {
            enemySpawn = gameState.Instance.redLocation.transform.position;
            gameState.Instance.blueQ.Enqueue(gameObject);
        }
        else if(gameObject.tag == "redTeam")
        {
            enemySpawn = gameState.Instance.blueLocation.transform.position;
            gameState.Instance.redQ.Enqueue(gameObject);
        }
        
    }
    void Update()
    {
        if (!blocked)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemySpawn, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == gameObject.tag)
        {
            blocked = true;
        }
        else if (collision.tag != gameObject.tag)
        {
            blocked = true;
            StartCoroutine(Attack());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "blueTeam" || collision.tag == "redTeam")
        {
            blocked = false;
            if(gameObject.tag == "blueTeam")
            {
                gameObject.GetComponent<Animator>().Play("melee_Idle");
            }
            else if(gameObject.tag == "redTeam")
            {
                gameObject.GetComponent<Animator>().Play("red_Melee");
            }
        }
    }
    IEnumerator Attack()
    {
        while (blocked)
        {
            yield return new WaitForSeconds(.5f);
            if (gameState.Instance.redHP > 0 && gameObject.tag == "blueTeam")
            {
                gameObject.GetComponent<Animator>().Play("melee_Animation");
                int smack = Random.Range(0, 6);
                if(smack < 5)
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
                gameObject.GetComponent<Animator>().Play("red_Melee1");
                int smack = Random.Range(0, 6);
                if (smack < 5)
                {
                    hitBlue();
                }
                else
                {
                    hitMiss();
                }
            }
            yield return new WaitForSeconds(.5f);
        }
    }
    void hitRed()
    {
        gameState.Instance.redHP -= 5;
    }
    void hitBlue ()
    {
        gameState.Instance.blueHP -= 5;
    }
    //Maybe add small flavor text saying "Miss" like in tft
    void hitMiss()
    {
        Debug.Log("Miss");
    }

}

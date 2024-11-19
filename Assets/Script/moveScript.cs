using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public bool block;
    public bool enemyBlock;
    public int speed;
    Vector2 enemySpawn;


    public static moveScript Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        if (gameObject.tag == "blueTeam")
        {
            enemySpawn = gameState.Instance.redLocation.transform.position;
            gameState.Instance.blueQ.Enqueue(gameObject);
        }
        else if (gameObject.tag == "redTeam")
        {
            enemySpawn = gameState.Instance.blueLocation.transform.position;
            gameState.Instance.redQ.Enqueue(gameObject);
        }

    }
    void Update()
    {
        if (!block)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemySpawn, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            block = true;
        }
        
        if (collision.tag != gameObject.tag)
        {
            block = true;
            enemyBlock = true;
            StartCoroutine(Smack());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "blueTeam" || collision.tag == "redTeam")
        {
            block = false;
            enemyBlock = false;
        }
    }
    IEnumerator Smack()
    {
        while (enemyBlock)
        {
            yield return new WaitForSeconds(1f);
            if (gameState.Instance.redHP > 0 && gameObject.tag == "blueTeam")
            {
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
            yield return new WaitForSeconds(.5f);
        }
    }
    void hitRed()
    {
        gameState.Instance.redHP -= 1;
    }
    void hitBlue()
    {
        gameState.Instance.blueHP -= 1;
    }
    void hitMiss()
    {
        Debug.Log("Miss");
    }
}

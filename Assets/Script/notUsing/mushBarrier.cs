using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushBarrier : MonoBehaviour
{
    public float scanRadius;
    public LayerMask filterMask;
    private mushSpawn mushSpwn;
    private Collider2D checkCollider;

    private void Awake()
    {
        mushSpwn = FindObjectOfType<mushSpawn>();
    }
    private void Start()
    {
        spawnCheck();
    }
    void spawnCheck()
    {
        checkCollider = Physics2D.OverlapCircle(transform.position, scanRadius, filterMask);
        if (checkCollider != null && checkCollider.transform != transform)
        {
            Debug.Log("Hi");
            Destroy(gameObject);
        }
        else
        {
            mushSpwn.currentAmount++;
        }
    }
    protected void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, scanRadius);
    }
}

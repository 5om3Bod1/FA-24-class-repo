using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Move : MonoBehaviour
{
    //From isometric tile map tutorial
    private Rigidbody rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed; 
        rb.velocity = new Vector3(moveH, 0, moveV);
        Vector3 direction = new Vector3(moveH, 0, moveV);
        FindObjectOfType<player_Anim>().SetDirection(direction);
    }
}

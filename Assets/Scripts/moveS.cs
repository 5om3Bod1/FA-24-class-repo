using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveS : MonoBehaviour
{
    Rigidbody body;

    float horizontal;
    float vertical;

    public float runSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Gives a value between -1 and 1
        vertical = Input.GetAxisRaw("Vertical"); // -1 is left
    }

    void FixedUpdate()
    {
        body.velocity = new Vector3(horizontal * runSpeed, vertical * runSpeed);
    }
}

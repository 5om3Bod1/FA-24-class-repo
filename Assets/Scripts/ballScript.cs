using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    //XinYi's Bounce Script
    public Rigidbody rb;
    public float xdirection = 5f;
    public float ydirection = -2f;
    Vector3 lastVelocity;
    float currSpeed;
    Vector3 direction;
    //

    public float maxspd;
    public float minspd;
    public GameObject txt;
    public AudioSource playOne;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        //XinYi's
        rb.AddForce(xdirection, ydirection, 0f, ForceMode.VelocityChange);
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 1;
            Destroy(txt);
        }

        //XinYi's
        lastVelocity = rb.velocity;
        //
    }
    private void OnCollisionEnter(Collision collision)
    {
        //XinYi's
        currSpeed = lastVelocity.magnitude;
        direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * currSpeed;

        if (collision.collider.CompareTag("Wall"))
        {
            transform.position = new Vector3(0, Random.Range(-1f, 1f), 0);
        }
        //

        if(currSpeed > maxspd)
        {
            lastVelocity = lastVelocity.normalized * maxspd;
        }
        else if(currSpeed < minspd)
        {
            lastVelocity = lastVelocity.normalized * minspd;
        }

        if (collision.collider.CompareTag("Speed"))
        {
            playOne.Play();
        }
    }

}

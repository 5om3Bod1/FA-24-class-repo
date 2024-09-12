using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointWarp : MonoBehaviour
{
    public int var;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("roll", 2f);
        Invoke("roll", 4f);
        Invoke("roll", 6f);
        Invoke("roll", 8f);
        Invoke("roll", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        if (var == 1)
        {
            gameObject.transform.position = new Vector2(0f, 2.25f);
        }else if(var == 2)
        {
            gameObject.transform.position = new Vector2(-4.5f, 0f);
        }else if(var == 3)
        {
            gameObject.transform.position = new Vector2(0f, -2.25f);
        }else if(var == 4)
        {
            gameObject.transform.position = new Vector2(4.5f, 0f);
        }
    }
    private void roll()
    {
        var = Random.Range(1, 5);
    }
}

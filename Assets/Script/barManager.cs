using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barManager : MonoBehaviour
{
    public Slider slimeE;
    public bool onPlate;
    
    public Slider powerS;
    public bool onPower;

    public Slider voidH;

    public slimeScript slimeS;
    public GameObject slimeC;

    public int sceneNum;

    private void Awake()
    {
        slimeS = slimeC.GetComponent<slimeScript>();
    }

    void Start()
    {
        StartCoroutine(slimeEvent());
        StartCoroutine(voidEvent());
        StartCoroutine(powerEvent());
    }

    private IEnumerator slimeEvent()
    {
        yield return new WaitForSeconds(.5f);
        if (slimeS.plate)
        {
            if (slimeE.value > 0)
            {
                slimeE.value-=3;
                powerS.value+=4;
                StartCoroutine(slimeEvent());
            }
        }
        else if (!slimeS.plate)
        {
            if (slimeE.value == 0 || slimeE.value < 100)
            {
                slimeE.value+=2;
                StartCoroutine(slimeEvent());
            }
        }
    }
    private IEnumerator powerEvent()
    {
        if (onPower)
        {
            powerS.value-=2;
            yield return new WaitForSeconds(.5f);
            StartCoroutine(powerEvent());
        }
        else
        {
            yield return new WaitForSeconds(.5f);
            StartCoroutine(powerEvent());
        }
    }
        
    private IEnumerator voidEvent()
    {   
        yield return new WaitForSeconds(1f);
        voidH.value-=3;
        if(voidH.value == 0)
        {
            SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
        }
        StartCoroutine(voidEvent());
    }
}
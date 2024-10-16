using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barManager : MonoBehaviour
{
    public Slider slimeE;
    public bool onPlate;
    
    public Slider powerS;
    public bool onPower;

    public Slider voidH;

    void Start()
    {
        StartCoroutine(slimeEvent());
        StartCoroutine(voidEvent());
        StartCoroutine(powerEvent());
    }

    private IEnumerator slimeEvent()
    {
        if (onPlate)
        {
            if (slimeE.value > 0)
            {
                slimeE.value--;
                powerS.value++;
                yield return new WaitForSeconds(.5f);
                StartCoroutine(slimeEvent());
            }
        }
        else if (!onPlate)
        {
            if (slimeE.value == 0 || slimeE.value < 100)
            {
                slimeE.value+=2;
                
                yield return new WaitForSeconds(.5f);
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
        voidH.value--;
        yield return new WaitForSeconds(1f);
        StartCoroutine(voidEvent());
    }
}
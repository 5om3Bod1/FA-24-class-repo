using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject progBar;
    public int timeLeft;
    public GameObject DirectLight;
    public GameObject rescueLight;
    public bool gameTime;

    public CanvasGroup blackOut;

    
    public static gameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        StartCoroutine(timer());
    }
    IEnumerator timer()
    {
        Light dirLight = DirectLight.GetComponent<Light>();
        yield return new WaitForSeconds(1f);
        timeLeft--;
        if(timeLeft < 180)
        {
            RenderSettings.ambientIntensity -= .0033f;
            dirLight.intensity -= .0055f;
            if(timeLeft <= 150 && RenderSettings.fogDensity < .04f)
            {
                RenderSettings.fogDensity += .001f;
            }
            else if (timeLeft <= 60 && RenderSettings.fogDensity < .06f)
            {
                rescueLight.SetActive(true);
                RenderSettings.fogDensity += .0005f;
            }
            else if(timeLeft == 20)
            {
                StartCoroutine(fadeIn());
            }
        }
        if (timeLeft == 0)
        {
            gameTime = true;
        }
        else if(timeLeft != 0)
        {
            Debug.Log(timeLeft);
            StartCoroutine(timer());
        } 
    }

    IEnumerator fadeIn()
    {
        blackOut.alpha += .05f;
        yield return new WaitForSeconds(1f);
        StartCoroutine(fadeIn());
    }
}
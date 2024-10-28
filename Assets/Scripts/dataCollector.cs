using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataCollector : MonoBehaviour
{
    public GameObject[] checkPoint;

    // Start is called before the first frame update
    void Start()
    {
        test();
    }

    void test()
    {
        //Walk Speed
        if (sliderCollector.IInstnace.slider[0].value == 0)
        {
            FirstPersonDrifter.IInstnace.walkSpeed = 3f;
            Debug.Log(FirstPersonDrifter.IInstnace.walkSpeed);
        }
        else if(sliderCollector.IInstnace.slider[0].value == 1)
        {
            FirstPersonDrifter.IInstnace.walkSpeed = 3.5f;
            Debug.Log(FirstPersonDrifter.IInstnace.walkSpeed);
        }
        else if (sliderCollector.IInstnace.slider[0].value == 2)
        {
            FirstPersonDrifter.IInstnace.walkSpeed = 4f;
            Debug.Log(FirstPersonDrifter.IInstnace.walkSpeed);
        }

        //Jump Height
        if (sliderCollector.IInstnace.slider[1].value == 0)
        {
            FirstPersonDrifter.IInstnace.jumpSpeed = 3f;
            FirstPersonDrifter.IInstnace.gravity = 5f;
        }
        else if (sliderCollector.IInstnace.slider[1].value == 1)
        {
            FirstPersonDrifter.IInstnace.jumpSpeed = 4f;
            FirstPersonDrifter.IInstnace.gravity = 5.5f;

        }
        else if (sliderCollector.IInstnace.slider[1].value == 2)
        {
            FirstPersonDrifter.IInstnace.jumpSpeed = 6f;
            FirstPersonDrifter.IInstnace.gravity = 7f;

        }

        //Time Amount
        if (sliderCollector.IInstnace.slider[2].value == 0)
        {
            countDown.IInstnace.timeLeft = 15;
        }
        else if (sliderCollector.IInstnace.slider[2].value == 1)
        {
            countDown.IInstnace.timeLeft = 30;
        }
        else if (sliderCollector.IInstnace.slider[2].value == 2)
        {
            countDown.IInstnace.timeLeft = 60;
        }

        //Checkpoint Amount
        if (sliderCollector.IInstnace.slider[3].value == 0)
        {
            checkPoint[0].SetActive(true);
        }
        else if (sliderCollector.IInstnace.slider[3].value == 1)
        {
            checkPoint[0].SetActive(true);
            checkPoint[1].SetActive(true);
        }
        else if (sliderCollector.IInstnace.slider[3].value == 2)
        {
            checkPoint[0].SetActive(true);
            checkPoint[1].SetActive(true);
            checkPoint[2].SetActive(true);
        }
    }
}

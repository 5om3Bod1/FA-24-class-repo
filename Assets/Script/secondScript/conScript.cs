using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class conScript : MonoBehaviour
{
    public TMP_Text[] rText;
    //public int[] yText;

    private void Start()
    {
        //Crimson
        rText[0].text = amountHolder.Instance.crimsonCount.ToString();

        //Death
        rText[1].text = amountHolder.Instance.deathCount.ToString();
        
        //Horn
        rText[2].text = amountHolder.Instance.hornCount.ToString();

        //Fall
        rText[3].text = amountHolder.Instance.fallCount.ToString();

        //Poison
        rText[4].text = amountHolder.Instance.poisonCount.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameState : MonoBehaviour
{
    //5 hitboxes
    public GameObject[] hitBox;
    public int showBox;

    void Start()
    {
        StartCoroutine(appearBox());
        Invoke("sceneSwap", 15f);
    }
    void stateChange()
    {          
        showBox = Random.Range(0, 5);
        foreach (GameObject item in hitBox)
        {
            if (item != hitBox[showBox])
            {
                Debug.Log("Hi");
                item.SetActive(false);
            }
            hitBox[showBox].SetActive(true);
            Debug.Log(showBox);
        }
    }
    IEnumerator appearBox()
    {
        stateChange();
        Debug.Log(showBox);
        yield return new WaitForSeconds(3f);
        StartCoroutine(appearBox());
    }
    void sceneSwap()
    {
        int num = 1;
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}

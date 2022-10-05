using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Scenee3Trigger : MonoBehaviour
{

    
    public GameObject Scene3Trigger;
    public GameObject Loading;
    public GameObject FadeOut;

    private void OnTriggerEnter( )
    {
        GetComponent<BoxCollider>().enabled = false;
        
          
        StartCoroutine(FadeExit());
    }

    IEnumerator FadeExit()
    {
        yield return new WaitForSeconds(1);
        FadeOut.SetActive(true);
        Loading.SetActive(true);
        yield return new WaitForSeconds(4.5f);

        SceneManager.LoadScene(7);
    }

}

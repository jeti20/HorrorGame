using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TriggerToScene3 : MonoBehaviour
{

    public float TheDistance;
    public GameObject Scene3Trigger;

    private void OnTriggerEnter( )
    {
        StartCoroutine(FadeExit());
    }

    IEnumerator FadeExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(7);
    }

}

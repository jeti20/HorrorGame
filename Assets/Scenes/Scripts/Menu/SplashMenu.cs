using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakeToMenu());
    }

    IEnumerator TakeToMenu()
    {
        yield return new WaitForSeconds(2.8f);
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using TMPro;

public class AOpening : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    public AudioSource line1;
    public AudioSource line2;
    


    // Start is called before the first frame update
    void Start()
    {
        //blokujemy gracza na pocz¹tku gry, ¿eby wyœwietli³ siênapis 
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<TextMeshProUGUI>().text = "... wherer am I?";
        line1.Play();
        yield return new WaitForSeconds(2); //trwa dwie sekuny 
        TextBox.GetComponent<TextMeshProUGUI>().text = ""; //przerwa 
        yield return new WaitForSeconds(0.5f);
        TextBox.GetComponent<TextMeshProUGUI>().text = "I need to get out of here.";
        line2.Play();
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<TextMeshProUGUI>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }


}

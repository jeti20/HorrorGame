using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using TMPro;

public class BArrowTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;
    public AudioSource line3;

    private void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        ThePlayer.GetComponent<FirstPersonController>().enabled = false; //zatrzymanie postaci
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<TextMeshProUGUI>().text = "Looks like a weapon on that table";
        line3.Play();
        yield return new WaitForSeconds(2.5f); //czekanie z tekstem przez 2,5s
        TextBox.GetComponent<TextMeshProUGUI>().text = ""; //wy³¹cza teks
        ThePlayer.GetComponent<FirstPersonController>().enabled = true; //pozwala postaci siê ruszaæ
        TheMarker.SetActive(true);
    }
}

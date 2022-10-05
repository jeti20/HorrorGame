using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CZoombieTrigger : MonoBehaviour
{

    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheMonster;
    public GameObject TheDoor;
    public AudioSource AmbMusic;
    //public AudioSource AmbMusic;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        
        TheDoor.GetComponent<Animation>().Play("DoorShhot");
        DoorBang.Play();
        TheMonster.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        AmbMusic.Stop();
        //AmbMusic.Stop();
        DoorJumpMusic.Play();
    }



}
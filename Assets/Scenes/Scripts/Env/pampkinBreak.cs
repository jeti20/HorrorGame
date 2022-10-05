using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pampkinBreak : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphareObject;
    public GameObject LightKey;
    public GameObject KeyObject;
    public GameObject keyTrigger;
    public AudioSource breakSound;
    // GameObject KeyObject;
    //public GameObject keyTrigger;

    void DamageZombie(int DamageAmount)
    {
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        breakSound.Play();
        KeyObject.SetActive(true);
        keyTrigger.SetActive(true);
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphareObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphareObject.SetActive(false);
        LightKey.SetActive(true);
        LightKey.GetComponent<Animation>().Play("light_key");

    }
}

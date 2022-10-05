using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeftEyePickUp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject theLeftEye;

    public GameObject halfFade;
    public GameObject eyeImg;
    public GameObject eyeText;


    //zmodyfikwoany skrypt "pickuppistol"

    //Update is called once per frame
    void Update()
   {
        TheDistance = PlayerCasting.DistanceFromTarget;  // PlayerCasting to nazwa poprzedniego skryptu który pokazuje w jakiej odleg³oœci jesteœ od obieku jakiegoœ, a DistanceFromTarget to zmienna z tamtego skryptu
  } 

    private void OnMouseOver()
    {
        //sprawdzamy czy dystans jest odp (czy gracz jest blisko klucza)
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text = "Pick up left eye";
            ActionDisplay.SetActive(true); //wyœweitalnie litery canvas 
            ActionText.SetActive(true);
        }
        //Czy klikamy klawisz akcji czy nie "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                //wy³¹czamy boxcolier na DorHinge
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                InventoryGlobal.leftEye = true; // ta linijka odnosi siê do skryptu GlobalInventory, do tego ¿eby mo¿na by³o podnieœæ lewo oko. 
                StartCoroutine(EyePickedUp());
            }

        }


    }

    //canvasy znikaj¹ jak jesteœmy dalej
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator EyePickedUp()
    {
        halfFade.SetActive(true);
        eyeImg.SetActive(true);
        eyeText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        theLeftEye.SetActive(false);
        halfFade.SetActive(false);
        eyeImg.SetActive(false);
        eyeText.SetActive(false);
        

    }
}

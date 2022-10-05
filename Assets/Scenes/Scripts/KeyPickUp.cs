using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPickUp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject TheKey;


    //zmodyfikwoany skrypt "pickuppistol"

    //Update is called once per frame
    void Update()
   {
        TheDistance = PlayerCasting.DistanceFromTarget;  // PlayerCasting to nazwa poprzedniego skryptu kt�ry pokazuje w jakiej odleg�o�ci jeste� od obieku jakiego�, a DistanceFromTarget to zmienna z tamtego skryptu
  } 

    private void OnMouseOver()
    {
        //sprawdzamy czy dystans jest odp (czy gracz jest blisko klucza)
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text = "Pick Up Key";
            ActionDisplay.SetActive(true); //wy�weitalnie litery canvas 
            ActionText.SetActive(true);
        }
        //Czy klikamy klawisz akcji czy nie "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                //wy��czamy boxcolier na DorHinge
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                TheKey.SetActive(false);
                InventoryGlobal.firstDoorKey = true; // ta linijka odnosi si� do skryptu GlobalInventory, do tego �eby mo�na by�o podnie�� kluicz. Wa�na linjka do to LockedDoor scrip poniewa� bez niej nie mo�na otworzyc drzwi po zebraniu klucza

            }

        }


    }

    //canvasy znikaj� jak jeste�my dalej
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}

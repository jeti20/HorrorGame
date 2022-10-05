using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClosedDoor : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject firstKeyDoor;
    public AudioSource BlockedDoors;
    public AudioSource CrackedDoors;
    



    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;         //sprawdzamy czy dystans jest odp (czy gracz jest blisko frzwi)
    }

    //sprawdzamy czy dystans jest odp (czy gracz jest blisko frzwi)

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text = "Open door";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        //Dwa warnuki musz¹ byæ spe³nione, musisz byæ wystarczaj¹co blisko if musi nadusiæ "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                //wy³¹czamy boxcolier na DorHinge
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                StartCoroutine(DoorReset());
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

    IEnumerator DoorReset()
    {
        if (InventoryGlobal.firstDoorKey == false)
        {
            BlockedDoors.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            firstKeyDoor.GetComponent<Animation>().Play("DoorOpen1");
            CrackedDoors.Play();
            yield return new WaitForSeconds(1.1f);
            this.GetComponent<BoxCollider>().enabled = false;
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUpPistol : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject ExtraCross;
    public GameObject GuideArrow;
    public GameObject ZoombieTrigger;



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
            ActionText.GetComponent<TextMeshProUGUI>().text = "Pick up pistol";
            ActionText.SetActive(true);
        }

//Dwa warnuki musz¹ byæ spe³nione, musisz byæ wystarczaj¹co blisko if musi nadusiæ "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                //wy³¹czamy boxcolier na DorHinge
                this.GetComponent < BoxCollider >().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                ExtraCross.SetActive(false);
                GuideArrow.SetActive(false);
                ZoombieTrigger.SetActive(true);
                
                
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
}

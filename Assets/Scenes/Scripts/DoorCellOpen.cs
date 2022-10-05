using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorCellOpen : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Thedoor;
    public AudioSource CreakSound;
    public GameObject ExtraCross;

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
            ActionText.SetActive(true);
        }

//Dwa warnuki musz� by� spe�nione, musisz by� wystarczaj�co blisko if musi nadusi� "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                //wy��czamy boxcolier na DorHinge
                this.GetComponent < BoxCollider >().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Thedoor.GetComponent<Animation>().Play("DoorOpen1");
                CreakSound.Play();
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

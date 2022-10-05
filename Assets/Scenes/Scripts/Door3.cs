using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Door3 : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject Thedoor;
    //public AudioSource CreakSound;
    public GameObject fadeout;
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
            ActionText.GetComponent<TextMeshProUGUI>().text = "Open door";
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        //Dwa warnuki musz by spenione, musisz by wystarczajco blisko if musi nadusi "E"
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                //wyczamy boxcolier na DorHinge
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                fadeout.SetActive(true);
                StartCoroutine(FadeExit());
                //Thedoor.GetComponent<Animation>().Play("DoorOpen1");
                //CreakSound.Play();
            }
        }
    }

    //canvasy znikaj jak jestemy dalej
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }




    IEnumerator FadeExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(5);
    }

}
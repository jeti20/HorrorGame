using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EyePlacement : MonoBehaviour 
{
    //TO JEST TEN SAM SKRYPT CO poICKuPkEY ALE ZMIENIONE Z THE KEY NA THE LEFT EYE I TEXT JEST INNY 
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;

    //zmienne dodane specjalnie do oka aby pojawia�y sie Canvas zwiazane z okiem 

    public GameObject Eyepieces;
    public GameObject realwall;
   
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;  // PlayerCasting to nazwa poprzedniego skryptu kt�ry pokazuje w jakiej odleg�o�ci jeste� od obieku jakiego�, a DistanceFromTarget to zmienna z tamtego skryptu
    }

    private void OnMouseOver()
    {
        if (InventoryGlobal.leftEye == true && InventoryGlobal.rightEye == true) //korzystamy ze skrypty poprzedniego GlobalInventory, dopiero po podniesieniu dw�ch cz�sci b�dzie mo�na po�o�y� obraz oka
        {
            //sprawdzamy czy dystans jest odp (czy gracz jest wystarczaj�co blisko)
            if (TheDistance <= 2)
            {
                ExtraCross.SetActive(true);
                ActionText.GetComponent<TextMeshProUGUI>().text = "Place eye pieces";
                ActionDisplay.SetActive(true); //wy�weitalnie litery canvas 
                ActionText.SetActive(true);
            }
            //Czy klikamy klawisz akcji czy nie "E"
            if (Input.GetButtonDown("Action"))
            {
                if (TheDistance <= 2)
                {                    
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ExtraCross.SetActive(false);
                    Eyepieces.SetActive(true); //sprawia �e obraz oka pojawia si�
                    realwall.GetComponent<Animator>().Play("WallMove");
                }
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

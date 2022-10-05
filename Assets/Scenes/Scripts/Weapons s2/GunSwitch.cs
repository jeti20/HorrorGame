using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunSwitch : MonoBehaviour
{

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (InventoryGlobal.M16 == true)
        {
            
            M16_M9();
        }

        if (InventoryGlobal.AK == true)
        {
            
            AK_M9();
        }

        if (InventoryGlobal.AK == true && InventoryGlobal.M16 == true)
        {
          
            All();
        }

    }
    void All()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
        }

        if (Input.GetKeyDown("2"))
        {
            Equip2();
        }

        if (Input.GetKeyDown("3"))
        {
            Equip3();
        }
        Debug.Log("Podniesione wszystkie borni");
    }
    void M16_M9()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
        }

        if (Input.GetKeyDown("2"))
        {
            Equip2();
        }
        Debug.Log("Podniesione M16 i M9");
    }
    void AK_M9()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
        }

        if (Input.GetKeyDown("3"))
        {
            Equip3();
        }
        Debug.Log("Podniesione AK i M9");
    }


    //Wyœwietlanie broni na ekranie
    void Equip1()
    {
        Slot1.SetActive(true);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
    }

    void Equip2()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(true);
        Slot3.SetActive(false);
    }

    void Equip3()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(true);
    }
}
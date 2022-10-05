using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public GameObject theAmmo;
    public GameObject ammoDispalyBox;
    //opakowanie amm znika po klikniêciu
    private void OnTriggerEnter()
    {
        ammoDispalyBox.SetActive(true);
        GlobalAmmo.ammoCount += 5;
        theAmmo.SetActive(false);
        
    }
}

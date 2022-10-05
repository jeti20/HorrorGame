using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
    public static int ammoCount;
    public GameObject ammoDisplay;
    public int internalAmmo;

    // Update is called once per frame
    void Update()
    {
        internalAmmo = ammoCount;
        ammoDisplay.GetComponent<TextMeshProUGUI>().text = "" + ammoCount ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("AutoSave", 5);
    }

    
}

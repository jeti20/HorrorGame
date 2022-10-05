using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGlobal : MonoBehaviour
{

    public static bool firstDoorKey = false;
    public bool internalDoorKey;
    public static bool leftEye = false;
    public static bool rightEye = false;

    public static bool AK = false;
    public static bool M16 = false;


    void Update()
    {
        internalDoorKey = firstDoorKey;
    }
}

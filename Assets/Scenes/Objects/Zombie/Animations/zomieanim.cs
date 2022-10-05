using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zomieanim : MonoBehaviour
{
    public GameObject zoombie;
    public void ChangeAnim()
    {
        zoombie.GetComponent<Animation>().Play("Z_Attack");
    }
    }

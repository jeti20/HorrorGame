using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapfloor : MonoBehaviour
{
    public GameObject Floor;

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(back());

    }

    IEnumerator back()
    {
        Floor.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        Floor.SetActive(true);
    }
}

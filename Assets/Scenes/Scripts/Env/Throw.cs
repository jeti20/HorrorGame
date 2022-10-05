using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject cupObject;
    public GameObject sphereTriger;

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        sphereTriger.SetActive(true);
        StartCoroutine(DeactiveSphere());
    }

    IEnumerator DeactiveSphere()
    {
        yield return new WaitForSeconds(0.5f);
        sphereTriger.SetActive(false);
        yield return new WaitForSeconds(2.5f);

    }
}

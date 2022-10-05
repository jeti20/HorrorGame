using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{
    public int LightMode;
    public GameObject FlameLight;

    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(AnimeLight());
        }

        IEnumerator AnimeLight()
        {
            LightMode = Random.Range(1, 4);
            if (LightMode == 1)
            {
                FlameLight.GetComponent<Animation> ().Play ("ilumination1");
            }
            if (LightMode == 2)
            {
                FlameLight.GetComponent<Animation>().Play("ilumination2");
            }
            if (LightMode == 3)
            {
                FlameLight.GetComponent<Animation>().Play("ilumination3");
            }
            yield return new WaitForSeconds(0.99f);
            LightMode = 0;
        }
    }
}

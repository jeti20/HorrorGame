using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public bool IsFiring = false; //czy uderza nas potw� 
    public float TargetDistance; //odleg�o�� potowra od gracza
    public int DamageAmout = 5; //obra�enia



    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.ammoCount >= 1) //sprawdza czy naci�niety jest przycisk strza�u i czy liczba naboi ze skryptu Global ammo jest wi�ksza niz 1
        {
            if (IsFiring == false)
            {
                GlobalAmmo.ammoCount -= 1; //odejmuje naboje z magazynka po strzeleneiu
                StartCoroutine(FiringPistol());
            }
        }
    }

    //animacje strzelania
    IEnumerator FiringPistol()
    {
        IsFiring = true;
        RaycastHit Shot; //zmienna
        //Do zadawania obra�e� zoombie
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmout, SendMessageOptions.DontRequireReceiver);
        }

        //TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("PistolFlame");
        GunFire.Play();
        yield return new WaitForSeconds(2f);
        MuzzleFlash.SetActive(false);
        IsFiring = false;

    }

}

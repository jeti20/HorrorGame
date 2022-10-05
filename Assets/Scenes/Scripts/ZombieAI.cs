using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hittinh;
    public AudioSource hurt1;
    public AudioSource hurt2;
    public AudioSource hurt3;
    public int hurtGen;
    public GameObject theFlash;



    private void Update()
    {
        transform.LookAt(thePlayer.transform); //make enemy looks at us
            if (attackTrigger == false)
             {
            
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed); // zmieñ pozycjê = idŸ w stronê zmieniaj¹c¹ siê pozycje obiektu thePlayer, idŸ z prêdkoœci¹ 0,01f
             }

        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0.01f;
            hittinh.Play();
            StartCoroutine(InflactDamage());
        }
    }
    private void OnTriggerEnter()
    {
        attackTrigger = true;
    }
    private void OnTriggerExit()
    {
        attackTrigger = false;
    }



    IEnumerator InflactDamage()
    {
        
        isAttacking = true;
        yield return new WaitForSecondsRealtime(1.1f);
        
        hurtGen = Random.Range(1, 4);
        if (hurtGen == 1)
        {
            hurt1.Play();
        }
        if (hurtGen == 2)
        {
            hurt2.Play();
        }
        if (hurtGen == 3)
        {
            hurt3.Play();
        }
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        theFlash.SetActive(false);
        GlobalHealth.currentHealth -= 5; //odwo³ujemy siê do zmienne jw skrypcie GlobalHealth
        //yield return new WaitForSecondsRealtime(0.1f);
        isAttacking = false;
        
    }

}

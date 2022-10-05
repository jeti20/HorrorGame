using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;
    public GameObject stalkerEnemy;
    public static bool isStalking;
    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>(); //tells the scrypt here is the agent 
    }


    void Update()
    {
        if (isStalking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Idle");
        }
        else
        {
            stalkerEnemy.GetComponent<Animator>().Play("RunMonster");
            stalkerAgent.SetDestination(stalkerDest.transform.position);
        }
    }
}

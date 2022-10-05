using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject monsterPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        GeneralSpawner();
    }



    //funkcja ta jest wywo³ywana powy¿ej po naciœniêciu S (respi losowe zwierze 
    void SpawnRandomMonster1()//void oznacza ze ta funkcja/metoda nie zwraca nic, tylko robi to co ma powiedziane
    {
        
        Vector3 spawnPosition = new Vector3(-20, 2, -14); // okreslamy gdzie maj¹ respiæ siê zwierzêta, zakres -20 - 20 na osi x i zawsze 20 na osi z
                                                                                                      //kolonuje pizze i zwraca tego klona
        Instantiate(monsterPrefab, spawnPosition, monsterPrefab.transform.rotation); //(zwierze z indkesem 0, w odleg³œci 20m od gracza, z rotacj¹ tak¹ jak¹ mia³ ustawiony prefab zweirzecia

    }

    void SpawnRandomMonster2()
    {

        Vector3 spawnPosition2 = new Vector3(20, 2, -14);
        Instantiate(monsterPrefab, spawnPosition2, monsterPrefab.transform.rotation * Quaternion.Euler(0, -90, 0));
    }

    void SpawnRandomMonster3()
    {

        Vector3 spawnPosition2 = new Vector3(-20, 2, 14);
        Instantiate(monsterPrefab, spawnPosition2, monsterPrefab.transform.rotation * Quaternion.Euler(0, 90, 0));
    }
    void SpawnRandomMonster4()
    {
        
        Vector3 spawnPosition2 = new Vector3(20, 2, 16);
        Instantiate(monsterPrefab, spawnPosition2, monsterPrefab.transform.rotation * Quaternion.Euler(0, 90, 0));
    }

    void GeneralSpawner()
    {
        InvokeRepeating("SpawnRandomMonster1", 7,  3f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
        InvokeRepeating("SpawnRandomMonster2", 7, 3f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
        InvokeRepeating("SpawnRandomMonster3", 7, 3f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
        InvokeRepeating("SpawnRandomMonster4", 7, 3f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
    }

}


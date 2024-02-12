using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] hazards;
    
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float minTimeBetweenSpawns;
    public float decrease;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
        if(timeBtwSpawns <= 0)
        {
            //random spawn point 
            Transform randomSpawnPoint = spawnPoint[Random.Range(0, spawnPoint.Length)];
            //random hazard from the hazards array
            GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];
            //spawn random hazard at random spawn point
            Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(30,-30))); 
            if (startTimeBtwSpawns > minTimeBetweenSpawns){
                startTimeBtwSpawns -= decrease;
            }
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
        }
    }
}

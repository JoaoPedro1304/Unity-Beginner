using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

   Vector3 randomPosition;
   public GameObject enemy;
   float timeToSpawn;

    void Update()
    {
        

        timeToSpawn += Time.deltaTime;

        if(TimeManager.gameTime < 15)
        {            
            if(timeToSpawn > Random.Range(5,10))
            {
                spawnEnemy(enemy);
                timeToSpawn =0;
            }
        }
        if(TimeManager.gameTime > 15 && TimeManager.gameTime < 30){
            if(timeToSpawn > Random.Range(5,10))
            {
                spawnEnemy(enemy);
                timeToSpawn =0;
            }
        }
        if(TimeManager.gameTime > 45){
            if(timeToSpawn > Random.Range(1,5))
            {
                spawnEnemy(enemy);
                timeToSpawn = 0;
            }
        }
        
    }

    void spawnEnemy(GameObject enemy)
    {    
    randomPosition = new Vector3(Random.Range(-45,45),1.11f, Random.Range(-45,45));
    Instantiate(enemy,randomPosition, transform.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
   Vector3 randomPosition;
   public GameObject enemy;
   float timeToSpawn;
       
    void Update()
    {
        timeToSpawn += Time.deltaTime;

        if(TimeManager.gameTime < 50)
        {            
            if(timeToSpawn > Random.Range(10,15))
            {
                spawnEnemy(enemy);
                timeToSpawn =0;
            }
        }
        if(TimeManager.gameTime > 50 && TimeManager.gameTime < 80){
            if(timeToSpawn > Random.Range(5,10))
            {
                spawnEnemy(enemy);
                timeToSpawn =0;
            }
        }
        if(TimeManager.gameTime > 80){
            if(timeToSpawn > Random.Range(1,5))
            {
                spawnEnemy(enemy);
                timeToSpawn =0;
            }
        }
        
    }

    void spawnEnemy(GameObject enemy)
    {    
    randomPosition = new Vector3(Random.Range(0,45),1.11f, Random.Range(0,45));
    Instantiate(enemy,randomPosition, transform.rotation);
    }
}

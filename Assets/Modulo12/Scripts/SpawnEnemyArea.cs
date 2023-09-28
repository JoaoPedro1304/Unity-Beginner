using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyArea : MonoBehaviour
{
   Vector3 randomPosition;
   public GameObject enemy;
   float timeToSpawn;

   Vector3 spawnArea;
       
    void Update()
    {
        spawnArea = transform.position;

        timeToSpawn += Time.deltaTime;

        if(TimeManager.gameTime < 50)
        {            
            if(timeToSpawn > Random.Range(1,6))
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
    randomPosition = new Vector3(Random.Range(spawnArea.x-5 , spawnArea.x+5),1.11f, Random.Range(spawnArea.z-9,spawnArea.z+9));
    Instantiate(enemy,randomPosition, transform.rotation);
    }
}

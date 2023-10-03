using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawLifePill : MonoBehaviour
{
    [SerializeField] GameObject lifePill;
    float time, timeToSpawn;
    int life;
    Vector3 randomPositionLifePill;
    int count;
    void Start()
    {
        timeToSpawn = 5;
        life = 15;
        count = 0;        
    }

    
    void Update()
    {
        randomPositionLifePill = new Vector3(Random.Range(0,45),1,Random.Range(0,45));
        time = Time.deltaTime;

        if(time > Random.Range(timeToSpawn + count,25))
        {
            Instantiate(lifePill,randomPositionLifePill,Quaternion.identity);
            count ++;
            if(count >=10 )
            {
                count =0;
                timeToSpawn =5;

            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().ReciveLife(life);
            Destroy(gameObject);
        }
    }
}

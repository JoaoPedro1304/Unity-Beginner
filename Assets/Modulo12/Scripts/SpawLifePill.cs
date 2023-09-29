using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawLifePill : MonoBehaviour
{
    [SerializeField] GameObject lifePill;
    float time;
    int life;
    Vector3 randomPositionLifePill;
    void Start()
    {
        
    }

    
    void Update()
    {
        randomPositionLifePill = new Vector3(Random.Range(0,45),1,Random.Range(0,45));
        time = Time.deltaTime;

        if(time > Random.Range(10,35))
        {
            Instantiate(lifePill,randomPositionLifePill,Quaternion.identity);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

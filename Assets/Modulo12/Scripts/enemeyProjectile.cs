using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyProjectile : MonoBehaviour
{
    int damage;
    
    void Start()
    {
        damage = 5;
        
    }
    
    void Update()
    {

        transform.position = transform.position + transform.forward * 30 * Time.deltaTime;

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hited");
            collision.gameObject.GetComponent<Player>().SufferDamage(damage);
            Destroy(gameObject);
        }
    }
}

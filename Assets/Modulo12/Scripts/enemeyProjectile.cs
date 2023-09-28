using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemeyProjectile : MonoBehaviour
{
    public int damage;
    void Start()
    {
        damage = 2;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + transform.forward * 2 * Time.deltaTime;

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<Player>().SufferDamage(damage);
        }
    }
}


using UnityEngine;

public class Projectile : MonoBehaviour
{
    float timeToDestroy;
    public float speed;
    public int damage;
    private void Update()
    {        
        transform.position += transform.forward * speed * Time.deltaTime;

        if(speed > 100){

            Collider collider = GetComponent<Collider>();
            collider.enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "enemy")
        {
            collision.transform.GetComponent<Enemy>().SufferDamage(damage);
            Destroy(gameObject); 
        }                       
       
    }  
    
}

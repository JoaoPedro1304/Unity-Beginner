
using Unity.Mathematics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float time;
    float timeToDestroy;
    public float speed;
    public int damage;
    public static int points;
    [SerializeField] ParticleSystem hitParticle;
    void Start()
    {
        points = 0;
    }
    void Update()
    {
          
        time += Time.deltaTime;

        transform.position += transform.forward * speed * Time.deltaTime;
        
        if(time > 5){
            Destroy(gameObject);
            time =0;
        }

        if(speed > 100){

            Collider collider = GetComponent<Collider>();
            collider.isTrigger = true;
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "enemy")
        {
            Instantiate(hitParticle,transform.position,Quaternion.identity);
            Destroy(gameObject); 
            points +=2;
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "enemy")
        {
            collision.transform.GetComponent<Enemy>().SufferDamage(damage);
            Instantiate(hitParticle,transform.position,Quaternion.identity);
            Destroy(gameObject);
            points +=2; 
        }
               
    }  
   
    
}

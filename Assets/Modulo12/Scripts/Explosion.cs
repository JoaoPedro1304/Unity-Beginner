
using TMPro;

using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] TMP_Text lifeText;
    [SerializeField] ParticleSystem explosionParticle;    
    [SerializeField] AudioSource explosionSound;

    float time=0;
    int life = 45;
    int damage = 0;
    int explosionDamage =51;    
    void Start()
    {
        lifeText.text = life.ToString();
        
    }
    
    void Update()
    {
        if(life <= 0)
        {
            time += Time.deltaTime;

            Instantiate(explosionParticle, transform.position, Quaternion.identity);            
            Destroy(GameObject.Find($"{gameObject.name}/barril"));
            explosionSound.Play();
            life = 1;
            if(time > 3)
            {
                Destroy(gameObject);
            }

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            damage = collision.gameObject.GetComponent<Projectile>().damage;
            life -= damage;
            lifeText.text = life.ToString();            
        }
       
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "projectile" && collider.gameObject.GetComponent<Projectile>().speed > 100)
        {
            damage = collider.gameObject.GetComponent<Projectile>().damage;
            life -= damage;
            lifeText.text = life.ToString();            
        }        
    }
   
    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "enemy" && life <= 1)
        {
            //Debug.Log("Inside the explosion area");
            
            Debug.Log("Explode");
            collider.gameObject.GetComponent<Enemy>().SufferDamage(explosionDamage);               
            
        }
    }

 
}

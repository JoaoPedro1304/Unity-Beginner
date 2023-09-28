using TMPro;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] TMP_Text lifeText;
    [SerializeField] ParticleSystem explosionParticle;
    int life = 75;
    int damage = 0;
    int explosionDamage;    
    void Start()
    {
        lifeText.text = life.ToString();
        explosionDamage = 51;
    }
    
    void Update()
    {
      
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
        if(collider.gameObject.tag == "enemy")
        {
            Debug.Log("Inside the explosion area");
            if(life <= 0)
            {
                Debug.Log("Explode");
                collider.gameObject.GetComponent<Enemy>().SufferDamage(explosionDamage);
                Instantiate(explosionParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}

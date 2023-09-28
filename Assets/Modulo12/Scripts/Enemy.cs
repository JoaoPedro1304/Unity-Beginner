using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]TMP_Text lifeText;
    [SerializeField]TMP_Text enemyName;    
    [SerializeField] List<EnemyType> enemyType;
    [SerializeField] ParticleSystem deathParticle;
    [SerializeField] GameObject enemyProjectile;
    GameObject player;    
    public int life;
    float speed;
    int random;
    

    void Start()
    {
        random = Random.Range(0,2);

        speed = enemyType[random].enemyEspeed;

        life = enemyType[random].enemyLife;

        lifeText.text = life.ToString();

        enemyName.text = enemyType[random].enemyName;
    }
    
    void Update(){
        
        player = GameObject.Find("Player");
    
        transform.LookAt(player.transform);        

        //transform.position = transform.position + transform.forward * speed * Time.deltaTime; 
           
        if(life <= 0){
            Instantiate(deathParticle,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void Shoot()
    {
        Instantiate(enemyProjectile, transform.forward, transform.rotation);
    }
    public void SufferDamage(int damage)
    {
        life -= damage;
        lifeText.text = life.ToString();        
    }
    

}
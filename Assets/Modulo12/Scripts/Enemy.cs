using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    float time;
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

        time += Time.deltaTime;

        player = GameObject.Find("Player");

        if(player != null)//tratemnto para morte do player
        {
            transform.LookAt(player.transform);
        }
                

        transform.position = transform.position + transform.forward * speed * Time.deltaTime; 
           
        if(life <= 0){
            Instantiate(deathParticle,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(time > 4 && player != null)
        {
            Shoot();
            time =0;
        }
    }
    void Shoot()
    {
        Instantiate(enemyProjectile, transform.position , transform.rotation);
    }
    public void SufferDamage(int damage)
    {
        life -= damage;
        lifeText.text = life.ToString();        
    }
    

}
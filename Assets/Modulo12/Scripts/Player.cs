using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    int life;
    bool isDead=false;
    float time;
    public GameObject player;
    public GameObject spawnPlayerArea;
    public TMP_Text lifeText;
    void Start()
    {
        life = 100;
    }
    void Update()
    {
        lifeText.text = life.ToString();
        if(life <=0 )
        {
            isDead =  true;
            Destroy(gameObject);
            SpawnPlayer();
        }
    }

    void SpawnPlayer()
    {       
        time += Time.deltaTime;
        if(isDead == true && time > 5)
        {  
            life= 100;

            Instantiate(player, spawnPlayerArea.transform.position, Quaternion.identity);

            isDead = false;
           
            time =0;
                       
        }
    }
    public void SufferDamage(int damage)
    {
        life -=damage;
    }
}

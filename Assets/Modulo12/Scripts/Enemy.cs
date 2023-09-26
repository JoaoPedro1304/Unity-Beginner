using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]TMP_Text lifeText;
    GameObject player; 
    int life;

    void Awake(){
        life = 100;
        lifeText.text = life.ToString();
    }
void Update(){

    player = GameObject.Find("Player");

    transform.LookAt(player.transform);
    transform.position = transform.position + transform.forward * 2 * Time.deltaTime; 
       
    if(life <= 0){
        Destroy(gameObject);
    }
}

public void SufferDamage(int damage)
{
    life -= damage;
    lifeText.text = life.ToString();
    
}
}

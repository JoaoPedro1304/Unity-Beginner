using TMPro;
using UnityEngine;


public class Player : MonoBehaviour
{
    int life;    
    public static bool isDead = false;
    public TMP_Text lifeText;
    void Start()
    {        
        life = 100;
        lifeText.text = "Life: "+life.ToString();
    }
    void Update()
    {   
        if(life >=100)
       {
            life =100;
       }
       if(life <=0)
       {
            isDead = true;
            Destroy(gameObject);
       }else
       {
            isDead = false;
       }

    }
    
    public void SufferDamage(int damage)
    {
        life -= damage;
        lifeText.text = "Life: "+life.ToString();
    }
    public void ReciveLife(int reciveLife)
    {
        if(life >= 100)
        {

        }else{
            life += reciveLife;
        }
    }   
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public AudioSource shootAudio;
    public List<Weapon> weaponList = new List<Weapon>();
    public GameObject projectilePrefab;    
    Weapon equipedWeapon;
    float lastTimeShoot;
    
      void Start()
    {
        equipedWeapon = weaponList[0];
    }

    
    void Update()
    {
        
        if(Input.GetKey("1")){
            equipedWeapon = weaponList[0];
            Debug.Log(equipedWeapon.name);
        }
        if(Input.GetKey("2")){
           equipedWeapon = weaponList[1];
           Debug.Log(equipedWeapon.name);
        }
        if(Input.GetKey("3")){
            equipedWeapon = weaponList[2];
            Debug.Log(equipedWeapon.name);
        }
          
        
        if(Input.GetKey(KeyCode.Mouse0) && equipedWeapon.fireRate + lastTimeShoot < Time.time)
        {
            lastTimeShoot = Time.time;

            if(equipedWeapon.projectileType == ProjectileType.Travel)
            {           
                                
                GameObject projectile = Instantiate(projectilePrefab, transform.position , transform.rotation);
                InitializeProjectile(projectile);
                shootAudio.Play();

            }
            if(equipedWeapon.projectileType == ProjectileType.HitScan)
            {
                shootAudio.Play();
                GameObject projectile = Instantiate(projectilePrefab, transform.position , transform.rotation);
                InitializeProjectile(projectile);

                if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Mathf.Infinity))
                {
                    if(hit.transform.gameObject.tag=="enemy")
                    {
                        hit.transform.GetComponent<Enemy>().SufferDamage(equipedWeapon.damage);
                    }
                }
            }
        }

            

    }

    void InitializeProjectile(GameObject projectile){

        Projectile projectileScript = projectile.GetComponent<Projectile>();
        projectileScript.speed = equipedWeapon.projectSpeed;
        projectileScript.damage = equipedWeapon.damage;
    }
    
}
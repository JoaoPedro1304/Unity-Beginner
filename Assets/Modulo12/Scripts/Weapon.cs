using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Weapon", menuName ="ScriptableObject/weapon")]
public class Weapon : ScriptableObject
{
    public ProjectileType projectileType;
    public float projectSpeed, fireRate;
    public int damage;
    
}

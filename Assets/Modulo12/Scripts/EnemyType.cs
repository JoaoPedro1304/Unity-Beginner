using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemy", menuName ="ScriptableObject/Enemy")]
public class EnemyType : ScriptableObject
{
    public int enemyLife;
    public float enemyEspeed;
    public string enemyName;
    
}

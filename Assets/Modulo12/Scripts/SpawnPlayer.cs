using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviour
{
    float time;
    [SerializeField] GameObject player;
    void Update()
    {
        if(Player.isDead == true)
        {
            Debug.Log(time);
            time+=Time.deltaTime;

            if(time > 5)
            {
                Debug.Log(time);
                                
                time = 0;

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
        }

    }
}

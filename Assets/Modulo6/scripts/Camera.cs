using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   [SerializeField] GameObject player;
   Vector3 cameraPosition = new Vector3(0, 8.229f, -6.710f);
 
   
    void Update(){
        transform.position = Vector3.Lerp(transform.position, player.transform.position+cameraPosition,0.01f);
    }
    
}

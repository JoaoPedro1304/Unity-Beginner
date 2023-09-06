using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    public Vector3 movePosition;
    void Start()
    {
        speed = 5;
    }


    void Update()
    {
       movePosition = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        
            transform.position += movePosition * speed * Time.deltaTime;
        

        
    }
    
    
}

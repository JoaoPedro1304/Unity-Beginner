using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] float speed;

    [Header("Camera")]
    [SerializeField] Transform cam;
    [SerializeField] float limitDistanceX, limitDistanceZ, minDistanceZ;     
    
       
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform; 
        
    }

    
    void Update()
    {       
        //cam = GameObject.Find("Main Camera").transform; 
        
        if(Input.GetKey("w"))
        {
            move(transform , Vector3.forward);
            if(Mathf.Abs(transform.position.z - cam.transform.position.z) > limitDistanceZ)
            {
                move(cam, Vector3.forward);
            }
                        
        }
        if(Input.GetKey("a"))
        {
            move(transform, Vector3.left);
            if(Mathf.Abs(transform.position.x - cam.position.x ) > limitDistanceX)
            {
                move(cam, Vector3.left);
            }
            
        }
        if(Input.GetKey("s"))
        {
            move(transform, Vector3.back);
            if(Mathf.Abs(transform.position.z - cam.position.z) < minDistanceZ)
            {
                move(cam, Vector3.back);
            }
            
        }
        if(Input.GetKey("d"))
        {
            move(transform, Vector3.right);
            if(Mathf.Abs(transform.position.x - cam.position.x) > limitDistanceX)
                {
                    move(cam, Vector3.right);
                }            
        }

        lookAtMouse();
    }

    void move( Transform gameObject, Vector3 direction){

        gameObject.position = gameObject.position + speed * Time.deltaTime * direction;
        
    }
    
    void lookAtMouse(){
        
        Vector3 mouse = Input.mousePosition;

        Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity,1 << 6))
        {
            mouse.z = hit.distance;                   
        }
        
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouse);
        mouseWorldPos.y = transform.position.y;

        transform.LookAt(mouseWorldPos);   
    }
}

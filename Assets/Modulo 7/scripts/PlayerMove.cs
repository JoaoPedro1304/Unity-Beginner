using UnityEngine;

public class PlayerMove : MonoBehaviour
{   
    Rigidbody rb;
    float speed = 0.3f;

    void Start(){
                
        rb = GetComponent<Rigidbody>();     
    }
    void Update(){
        
        if(Input.GetKeyDown(KeyCode.W)){

            rb.AddForce(new Vector3(0, 4f, 0), ForceMode.Impulse);
                        
        }
    
    }
  
}

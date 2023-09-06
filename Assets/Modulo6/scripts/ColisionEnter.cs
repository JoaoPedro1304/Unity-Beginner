using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionEnter : MonoBehaviour
{
    void Start(){
        
    }
    void OnCollisionEnter(Collision collision){
         
        if(collision.gameObject.name == "Plane"){
            SceneManager.LoadScene("Cena Modulo6 1", LoadSceneMode.Additive);
        }
        if(collision.gameObject.name == "Plane1"){
            SceneManager.LoadScene("Cena Modulo6 2", LoadSceneMode.Additive);
        }
        if(collision.gameObject.name == "Plane2"){
            SceneManager.LoadScene("Cena Modulo6 3", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Cena Modulo6 1");
        }
        if(collision.gameObject.name == "Plane3"){
            SceneManager.LoadScene("Cena Modulo6 4", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Cena Modulo6 2");
        }
        if(collision.gameObject.name == "Plane4"){  //ultima plataforma
            
            if(SceneManager.GetSceneByName("Cena Modulo6 3").isLoaded)
            {
                SceneManager.UnloadSceneAsync("Cena Modulo6 3");
            }   
                       
        }
                
    }

    
        
    
}

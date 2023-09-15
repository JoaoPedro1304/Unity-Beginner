using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{    
    float time=0;

    
    void OnTriggerEnter(Collider collider){

        if(collider.gameObject.tag =="CanCollide"){

            Time.timeScale = 0;

           while(time < 4){
            time +=Time.deltaTime;
           }

           if(time >= 4){
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                time =0; 
           } 
        }

    }
}

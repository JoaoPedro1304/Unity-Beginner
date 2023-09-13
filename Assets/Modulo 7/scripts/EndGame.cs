using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{    
    
    void OnTriggerEnter(Collider collider){

        if(collider.gameObject.tag =="CanCollide"){

            collider.gameObject.GetComponent<PlayerMove>().enabled = false;

            Time.timeScale = 0;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            Time.timeScale = 1;

        }

    }
}

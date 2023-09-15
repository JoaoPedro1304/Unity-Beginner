using UnityEngine;

public class InstantiateObstacles : MonoBehaviour
{
    [SerializeField] GameObject [] obstacle = new GameObject [2];
    [SerializeField] GameObject finalObstacle;
    
    float incrementPosition;
    float timeToInstantiate;
    int timer;

   void Start(){        
        timeToInstantiate = 0;

        for (int i = 0; i < 6 ;i++){

            incrementPosition+=10;

            GameObject newObstacle = Instantiate(obstacle[Random.Range(0,1)]);

            newObstacle.transform.position = new Vector3(incrementPosition,Random.Range(-1.1f,5.2f),0);

            Destroy(newObstacle,20);
        }      
        
   }

    void Update(){

       
        if(timeToInstantiate > 2)
        {
            incrementPosition +=10;

            GameObject newObstacle = Instantiate(obstacle[Random.Range(0,1)]);

            newObstacle.transform.position = new Vector3(incrementPosition,Random.Range(-1.1f,5.2f),0);

            Destroy(newObstacle,40);

            timeToInstantiate = 0;
        }
        
        if(timer>20){
            Instantiate(finalObstacle, new Vector3(incrementPosition,Random.Range(1.1f, 5.2f),0), Quaternion.identity);
            timeToInstantiate =0;
        }        
        
        timeToInstantiate+=Time.deltaTime;     

       }
}

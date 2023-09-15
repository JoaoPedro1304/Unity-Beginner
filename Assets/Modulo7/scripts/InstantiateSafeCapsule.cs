using UnityEngine;

public class InstantiateSafeCapsule : MonoBehaviour
{
    float incrementPosition;
    [SerializeField] GameObject safeCapsule;
    float time, timeToInstantiateObstacles;

    void Start(){
        incrementPosition = 0;
    }    

    void Update()
    {
        //tempo de instanciamento dos obstaculos
        if(timeToInstantiateObstacles >2){
            incrementPosition +=5;
            timeToInstantiateObstacles = 0;
        }
         

        if(time > Random.Range(5,10)){          

            Instantiate(safeCapsule, new Vector3 (incrementPosition, Random.Range(6 , 12), 0), Quaternion.identity);

            time = 0;
        }
       
        timeToInstantiateObstacles += Time.deltaTime;
        time +=Time.deltaTime;

    }
}

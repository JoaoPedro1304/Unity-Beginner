using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
   
    void Update()
    {
        transform.position -= new Vector3(3f,0,0) * Time.deltaTime;
    }
}

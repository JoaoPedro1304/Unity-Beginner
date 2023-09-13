using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 cameraPosition = new Vector3(0, 3.88f, -13.85f);
        
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, player.transform.position+cameraPosition ,0.005f);

    }
}

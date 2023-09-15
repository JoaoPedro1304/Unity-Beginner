using UnityEngine;

public class SafeCapsule : MonoBehaviour
{
    Material safeCapsuleMaterail;
    void Start(){
        safeCapsuleMaterail =  GetComponent<Renderer>().material;
    }
    void Update(){
        
        transform.position -= new Vector3(3f,0,0) * Time.deltaTime;

    }
    void OnTriggerEnter(Collider collider){

        collider.gameObject.tag = "CanNotCollide";
        collider.gameObject.GetComponent<Renderer>().material = safeCapsuleMaterail;
        Destroy(gameObject);

    }
}

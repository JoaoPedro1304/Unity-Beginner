using UnityEngine;
using UnityEngine.UI;

public class PlayerSafe : MonoBehaviour
{
    [SerializeField] Material defaultMaterial;
    [SerializeField] GameObject player;
    [SerializeField] Text timerText;
    Renderer myRenderer;
    float safeTime=0;
    

    void Start(){
        gameObject.tag = "CanCollide";
        myRenderer = GetComponent<Renderer>();
       

    }
   void Update(){
     
     
    if(gameObject.tag == "CanNotCollide"){
        
        safeTime+=Time.deltaTime;
        timerText.text = ((int)safeTime + 1).ToString();
             
    }

    if(safeTime>=4){

        timerText.gameObject.SetActive(false);

        gameObject.tag = "CanCollide";

        myRenderer.material = defaultMaterial;

        safeTime =0;
    }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeResScript : MonoBehaviour
{
    TMP_Dropdown dropdown;
   
    void Start()
    {
        dropdown = GetComponentInParent<TMP_Dropdown>();
        dropdown.value = 0;
    }

    // Update is called once per frame
    
    public void OnValueChange(){
        
        if (dropdown != null){

            if(dropdown.value == 0){                
                Screen.SetResolution(1920,1080,true);
            }else if(dropdown.value ==1){
                Screen.SetResolution(1024,768,true);
            }else{
                Screen.SetResolution(800,600,true);
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleFullScreen : MonoBehaviour
{
     Toggle _toggle;
    
    void Start(){
        _toggle = GetComponentInParent<Toggle>();
        Screen.fullScreen = _toggle.isOn;
    }
    public void ToggleScreenMode(){

        Screen.fullScreen = _toggle.isOn;
               
    }

}
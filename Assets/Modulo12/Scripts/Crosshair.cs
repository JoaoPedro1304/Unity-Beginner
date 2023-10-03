
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    [SerializeField] Image crosshair;    
    
    void Start()
    {
        Cursor.visible = false;
       
    }
    void Update()
    {
        crosshair.transform.position = Input.mousePosition;
    }
    
}

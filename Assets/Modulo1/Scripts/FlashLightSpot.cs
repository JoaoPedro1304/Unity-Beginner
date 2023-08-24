using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSpot : MonoBehaviour
{
    private Light _light;
    void Start()
    {
         _light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
       
        _light.intensity = Mathf.PingPong(Time.time*4, 14.2f);
    }
}

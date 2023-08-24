using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightPoint : MonoBehaviour
{
    private Light _light;
    void Start()
    {
        _light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        _light.intensity = Mathf.PingPong(Random.Range(0.8f, Time.time*8),1.8f);
    }
}

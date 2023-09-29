using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveAnounce : MonoBehaviour
{
    [SerializeField] TMP_Text waveText;
    float time;
    void Start()
    {
        waveText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        Debug.Log(time);

        if(time > 0.5f && time < 2)
        {            
            waveText.enabled = true;
            waveText.text = "Wave 1";
        }else if( time > 2)
        {
            waveText.enabled = false;
        }
        if(time > 15 && time < 17)
        {            
            waveText.enabled = true;
            waveText.text = "Wave 2";
        }else if( time > 12)
        {
            waveText.enabled = false;
        }
        if(time > 45 && time < 47)
        {            
            waveText.enabled = true;
            waveText.text = "Wave 3";
        }else if( time > 22)
        {
            waveText.enabled = false;
        }
    }
}

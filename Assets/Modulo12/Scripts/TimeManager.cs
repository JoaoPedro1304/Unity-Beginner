using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static float gameTime;
    public TMP_Text gameTimer;
    void Start()
    {
        gameTime = 0;
    }

    
    void Update()
    {
        gameTime += Time.deltaTime;
        gameTimer.text  = ((int)gameTime).ToString();
    }
}

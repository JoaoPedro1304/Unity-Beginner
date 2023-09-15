using UnityEngine;

public class TimeTextPosition : MonoBehaviour
{
    RectTransform timerRT;   
    [SerializeField] GameObject player;
    
    void Start()
    {
     timerRT = GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timerRT.anchoredPosition = new Vector2(player.transform.position.x + 5f , player.transform.position.y - 40);
    }
}

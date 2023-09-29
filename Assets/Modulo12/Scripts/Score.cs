using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    int points;
    void Start()
    {
        score.text = "Score: "+points.ToString();
    }
    void Update()
    {
        score.text = "Score: " + Projectile.points.ToString();
    }

}


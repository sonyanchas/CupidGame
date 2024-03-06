using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUIText;
    [SerializeField] TMP_Text TimerText;
    [SerializeField] TMP_Text TimerWordText;
    public int Score;
    [SerializeField] int TimeSet;
    public int Timer;
    //public Sushi player;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0; // Initialize score as 0

    }

    // Update is called once per frame
    void Update()
    {
        Timer = (TimeSet - (int)Time.time); // Make timer go down by the time and how much time set
        ScoreUIText.text = Score.ToString(); // Update both strings to show score and time
        TimerText.text = Timer.ToString();
        if (Timer == 0) //If timer hits 0, print game over and end  
        {
            TimerText.text = "Game Over";
            Time.timeScale = 0;
        }
    }
}

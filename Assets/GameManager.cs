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
        Score = 0;
        //TimeSet = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Timer = (TimeSet - (int)Time.time);
        //Timer = Time.time - Timer;
        ScoreUIText.text = Score.ToString();
        TimerText.text = Timer.ToString();
        if (Timer == 0)
        {
            TimerText.text = "Game Over";
            TimerWordText.text = "";
            Time.timeScale = 0;
        }
    }
}

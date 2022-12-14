using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public TMP_Text totalTime;
    public TMP_Text lives;
    public TMP_Text rounds;
    public TMP_Text timeLeft;

    void Start()
    {
        totalTime.text = HeadupDisplay.totalTime.ToString("00.00");
        lives.text = HeadupDisplay.lives.ToString();
        rounds.text = StartLineCollision.roundCounter.ToString();
        timeLeft.text = HeadupDisplay.timeRemaining.ToString("00.00");
    }
}

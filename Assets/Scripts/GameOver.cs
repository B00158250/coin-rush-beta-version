using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public TMP_Text totalTime;
    public TMP_Text lives;
    public TMP_Text rounds;

    void Start()
    {
        totalTime.text = "Total Time: " + HeadupDisplay.totalTime + " Seconds";
        lives.text = "Lives left: " + HeadupDisplay.lives;
        rounds.text = "Rounds done: " + StartLineCollision.roundCounter;
    }
}
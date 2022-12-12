using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeadupDisplay : MonoBehaviour
{

    public RawImage backGround;
    public TMP_Text timeLeftText;
    public TMP_Text totalTimeText;
    public TMP_Text totalLivesText;
    public static float timeRemaining = 30f;
    public static float totalTime = 0;
    public static int lives = 10;

    // time until headupdisplay should appear
    private float appearTime = 5.0f;

    void Update()
    {

        appearTime -= Time.deltaTime;

        if (appearTime < 0)
        {
            totalLivesText.text = "Total Lives:" + lives;
            backGround.color = Color.white;

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeLeftText.text = "Time Left: " + timeRemaining;

            } else
            {
                timeRemaining = 0;
                timeLeftText.text = "Time Left: " + timeRemaining;
                SceneManager.LoadScene("GameOver");
            }

            totalTime += Time.deltaTime;
            totalTimeText.text = "Total Time: " + totalTime;

        }

        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}

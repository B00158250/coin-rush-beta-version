using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    private bool onTheGorund;

    private float timeLeft = 4.0f;
    public TMP_Text startTimer; // used for showing countdown from 3, 2, 1 
    public TMP_Text gameStarts;
    public TMP_Text goText;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {

        // start game timer
        timeLeft -= Time.deltaTime;
        startTimer.text = (timeLeft).ToString("0");
        gameStarts.text = "Seconds until Start";

        // display go text
        if (timeLeft < 0)
        { 
            Destroy(startTimer);
            Destroy(gameStarts);
            goText.text = "GO!";
        }
        

        // start game when timer is zero and go was displayed
        if (timeLeft < -1)
        {
            Destroy(goText);
        
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            // check if the vehicle is not flying in the air
            if (transform.position.y > 6)
            {
                onTheGorund = false;
            }
            else
            {
                onTheGorund = true;
            }


            if (onTheGorund)
            {
                // Move the vehicle based on the vertical input
                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

                // Move the vehicle based on the horizontal input
                transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            }

        }


    }
}

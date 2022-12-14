using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public AudioSource coinSound;
   

    void Start()
    {

        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {


            // increase time remaining in HeadupDisplay clas
            HeadupDisplay.timeRemaining += 5;

            // play sound on collect
            coinSound.Play();

            // destroy coin
            Destroy(this.gameObject);
        }

    }

}

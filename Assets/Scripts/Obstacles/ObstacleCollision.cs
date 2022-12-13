using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    private bool decreasLives = true;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {

            if (decreasLives)
            {
                decreasLives = false;

                // decrease lives
                HeadupDisplay.lives--;

                GetComponent<AudioSource>().Play();

                // destroy obstacle
                Destroy(this.gameObject, 10);

                decreasLives = true;
            }

        }



    }

 


}

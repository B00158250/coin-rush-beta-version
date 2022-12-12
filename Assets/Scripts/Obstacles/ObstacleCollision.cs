using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    private bool decreasLives = true;

    IEnumerator OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {

            if (decreasLives)
            {
                decreasLives = false;

                // decrease lives
                HeadupDisplay.lives--;

                // wait for some seconds 
                yield return new WaitForSeconds(10);

                // destroy obstacle
                Destroy(this.gameObject);

                decreasLives = true;
            }

        }



    }

 


}

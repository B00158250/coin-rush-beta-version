using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            // increase time remaining in HeadupDisplay clas
            HeadupDisplay.timeRemaining += 10;

            // destroy coin
            Destroy(this.gameObject);
      
        
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLineCollision : MonoBehaviour
{

    public static int roundCounter = -1;
    public static int amountCoin = 30;
    public static int amountObstacle = 30;

    private bool doSpawn = false;

    public GameObject coin;
    public GameObject box;
    public GameObject cone;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {

            roundCounter++;

            Debug.Log("Start: rounds = " + roundCounter);

            doSpawn = true;


        }

    }

    void Update()
    {


        if (doSpawn)
        {

            doSpawn = false;

            if (roundCounter >= 1)
            {
                SpawnObjects.GenerateCoinsOnRandomPossition(coin, amountCoin / roundCounter);
                SpawnObjects.GenerateObstaclesOnRandomPossition(box, amountObstacle);
                SpawnObjects.GenerateObstaclesOnRandomPossition(cone, (amountObstacle / 2));
            }

            if (roundCounter <= amountCoin)
            {
                amountCoin = 30;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLineCollision : MonoBehaviour
{

    public static int roundCounter = -1;
    public static int amountCoin = 30;
    public static int amountObstacle = 1000;

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

            if (roundCounter > 1)
            {
                SpawnObjects.GenerateCoinsOnRandomPossition(coin, amountCoin / roundCounter);
                SpawnObjects.GenerateObstaclesOnRandomPossition(box, amountCoin / roundCounter);
                SpawnObjects.GenerateObstaclesOnRandomPossition(cone, amountCoin * roundCounter);
            }

            if (roundCounter <= amountCoin)
            {
                amountCoin = 30;
            }
        }

    }
}

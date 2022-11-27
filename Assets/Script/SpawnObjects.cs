using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject coin;
    public GameObject obstacle;
    public GameObject[] spawnPositionObjects;
    // Start is called before the first frame update

    // get size and spann range of object to spawn 
    private Vector3 size;
    private float spanX;
    private float spanZ;
   

    // position of spanPositionObject
    private float posX;
    private float posZ;

    // number of coins

    void Start()
    {
        SpawnElements(coin, 3);
        SpawnElements(obstacle, 10);
    }


    // this fuction spawns a given element ant qty on the track
    void SpawnElements(GameObject element, int howMany)
    {

        for (int i = 0; i < spawnPositionObjects.Length; i++)
        {
            size = spawnPositionObjects[i].GetComponent<Collider>().bounds.size;
            spanX = size.x / 2;
            spanZ = size.z / 2;

            posX = spawnPositionObjects[i].transform.position.x;
            posZ = spawnPositionObjects[i].transform.position.z;

            Debug.Log("Start");

            for (int x = 0; x < howMany; x++)
            {
                Vector3 randomPosition = new Vector3(Random.Range(posX - spanX, posX + spanX), 1, Random.Range(posZ - spanZ, posZ + spanZ));
                Instantiate(element, randomPosition, Quaternion.identity);
            }
        }
    }
}

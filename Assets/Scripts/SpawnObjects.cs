using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SpawnObjects : MonoBehaviour
{

    public GameObject box;
    public GameObject cone;
    public GameObject coin;


    void Start()
    {

        GenerateCoinsOnRandomPossition(coin, 30);
        GenerateObstaclesOnRandomPossition(box, 50);
        GenerateObstaclesOnRandomPossition(cone, 50);


    }

    public static void GenerateCoinsOnRandomPossition(GameObject coin, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 randPos = GetRandomLocation();
            randPos.y += 1;
            Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);
            Instantiate(coin, randPos, rotation);
        }
    }

    public static void GenerateObstaclesOnRandomPossition(GameObject obstacle, int amount)
    {

        for (int i = 0; i < amount; i++)
        {
            Vector3 randPos = GetRandomLocation();
            randPos.y += 0.1f;
            Instantiate(obstacle, randPos, Quaternion.identity);
            Debug.Log(randPos);
        }

    }

    public static Vector3 GetRandomLocation()
    {
        NavMeshTriangulation navMeshData = NavMesh.CalculateTriangulation();

        // Pick the first indice of a random triangle in the nav mesh
        int t = Random.Range(0, navMeshData.indices.Length - 3);

        // Select a random point on it
        Vector3 point = Vector3.Lerp(navMeshData.vertices[navMeshData.indices[t]], navMeshData.vertices[navMeshData.indices[t + 1]], Random.value);
        Vector3.Lerp(point, navMeshData.vertices[navMeshData.indices[t + 2]], Random.value);

        return point;
    }



}








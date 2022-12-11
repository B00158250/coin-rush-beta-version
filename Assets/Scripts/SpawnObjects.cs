using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{


     public GameObject coin;
     public GameObject obstacle;
    public GameObject track;

  


     void Start()
     {

      // Debug.Log(track.GetComponent<MeshFilter>().mesh.vertices.Length);

        
        for (int x = 0; x < 4; x++)        {
            Vector3 randomPosition = transform.transform.position;
            Instantiate(obstacle, randomPosition, Quaternion.identity);
        }
        
    }


    
}








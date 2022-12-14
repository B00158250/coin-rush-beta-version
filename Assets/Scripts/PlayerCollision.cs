using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ParticleSystem particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("coin"))
        {

            Instantiate(particleEffect, collisionInfo.transform.position, Quaternion.identity);
            particleEffect.Play();
        
        }

    }
}

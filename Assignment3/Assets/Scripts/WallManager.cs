using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public ParticleSystem collision;
    public RaycastHit hit;

    private void OnCollisionEnter2D(Collision2D other)
    {
      
        if (other.gameObject.CompareTag("Wall"))
         {
            Debug.Log("Lol");
            collision.Play();
         }
    }

    void Start()
    {
        
    }

    void Update()
    {

        
    }

}

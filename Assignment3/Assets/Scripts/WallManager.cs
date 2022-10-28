using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public ParticleSystem collision;
    public RaycastHit hit;
    [SerializeField] private AudioSource WallSoundEffect;


    private void OnCollisionEnter2D(Collision2D other)
    {
      
        if (other.gameObject.layer == LayerMask.NameToLayer("Walls"))
         {
            
            collision.Play();
            WallSoundEffect.Play();
        }
    }

    void Start()
    {
        
    }

    void Update()
    {

        
    }

}

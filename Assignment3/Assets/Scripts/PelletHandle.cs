using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletHandle : MonoBehaviour
{
    public int pts = 5;
    public AudioSource Source;
    public AudioClip Clip;

    public void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("F1 Car"))
        {
    
            gameObject.AddComponent<AudioSource>();

            Devour();
            Source.PlayOneShot(Clip);
        }
    }

    protected virtual void Devour()
    {
        FindObjectOfType<PelletManager>().PelletEaten(this);

        

    }


}

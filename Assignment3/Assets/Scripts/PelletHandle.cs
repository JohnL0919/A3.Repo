using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletHandle : MonoBehaviour
{
    public int pts = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("F1 Car"))
        {
            Devour();
        }
    }

    protected virtual void Devour()
    {
        FindObjectOfType<PelletManager>().PelletEaten(this);
    }
}

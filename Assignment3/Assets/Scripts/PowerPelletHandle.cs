using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletHandle : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}

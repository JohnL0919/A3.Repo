using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform telPos;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 pos = other.transform.position;

        pos.x = this.telPos.position.x;
        pos.y = this.telPos.position.y;

        other.transform.position = pos;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public float spawnTime = 10f;
    public GameObject BonusCherry;
    float destroyTime = 17.0f;
    public PelletManager p;
    void Start()
    {
        InvokeRepeating("spawnCherry", spawnTime, spawnTime);
    }
    
    void Update()
    {
        Destroy(gameObject, destroyTime);
    }

    void spawnCherry()
    {
        Vector3 cherryPos = new Vector3(Random.Range(-700f, -600f), Random.Range(-600f, -400f), 0f);
        Instantiate(BonusCherry, cherryPos, Quaternion.identity);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("F1 Car"))
        {
            Destroy(gameObject);
            p.UpdateScore(100);
        }
    }
}

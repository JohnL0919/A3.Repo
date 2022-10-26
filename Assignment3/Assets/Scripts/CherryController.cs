using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public float spawnTime = 10f;
    public GameObject BonusCherry;
    void Start()
    {
        InvokeRepeating("spawnCherry", spawnTime, spawnTime);
    }

    void Update()
    {
        
    }

    void spawnCherry()
    {
        Vector3 cherryPos = new Vector3(Random.Range(-700f, -600f), Random.Range(-600f, -400f), 0f);
        Instantiate(BonusCherry, cherryPos, Quaternion.identity);
        
    }
}

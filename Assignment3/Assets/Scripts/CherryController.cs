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
        Instantiate(BonusCherry, new Vector3(2.0f, 0, 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletHandle : PelletHandle
{


    protected virtual void Devour()
    {
        FindObjectOfType<PelletManager>().PowerPelletEaten(this);
    }
}

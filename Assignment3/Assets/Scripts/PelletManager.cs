using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletManager : MonoBehaviour
{

    public int score { get; private set; }
    public Transform pellets;

   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void SetScore(int score)
    {
        this.score = score; 
    }

    public void PelletEaten(PelletHandle pellet)
    {
        pellet.gameObject.SetActive(false);
        SetScore(this.score + pellet.pts);
    }

    public void PowerPelletEaten(PowerPelletHandle pellet)
    {
        pellet.gameObject.SetActive(false);
        SetScore(this.score + pellet.pts);
    }
}

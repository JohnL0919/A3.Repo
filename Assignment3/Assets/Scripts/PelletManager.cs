using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PelletManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public Transform pellets;
    [SerializeField] private AudioSource pelletSoundEffect;

    void Start()
    {

    }

    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }

    public void PelletEaten(PelletHandle pellet)
    {
        pelletSoundEffect.Play();
        pellet.gameObject.SetActive(false);
        UpdateScore(10);
    }
}

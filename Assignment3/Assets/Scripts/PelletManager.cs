using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PelletManager : MonoBehaviour
{
    public int score;
    public int lives { get; private set; }
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

    private void SetLives(int lives)
    {
        this.lives = lives;
    }

    public void PelletEaten(PelletHandle pellet)
    {
        pelletSoundEffect.Play();
        pellet.gameObject.SetActive(false);
        UpdateScore(10);
    }
}

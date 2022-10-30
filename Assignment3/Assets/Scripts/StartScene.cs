using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartScene : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeKeep;

    void Start()
    {
        
    }
    public void UpdateTime(float timeAdd)
    {
        timeKeep += timeAdd;
        timerText.text = "Score: " + timeKeep;
    }

    void Update()
    {
        UpdateTime(Time.deltaTime);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelOne : MonoBehaviour
{


    void Start()
    {

       
    }

    void Update()
    {
        
    }
    
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("LevelOne");
    }
}

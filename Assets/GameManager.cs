﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    

    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
       
    }

  

    public void gameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0; //To Pause the game
       
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeController : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadIttenSW()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadIttenPrim()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadIttenSek()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadFirstGame()
    {
        SceneManager.LoadScene(10);
    }
    public void LoadSecondGame()
    {
        SceneManager.LoadScene(16);
    }

    public void SkipGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void GoToScene(int number)
    {
        SceneManager.LoadScene(number);
    }

    public void BackToAusmalen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

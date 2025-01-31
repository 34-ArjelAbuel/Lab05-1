﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text coinText;
    private int coinCount;
    public int totalCoin;

    public Text timeText;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.Round(timer * 100.0f) * 0.01f;
    }
    public void AddCoin()
    {
        coinCount+= 10;
        coinText.text = "Coins Collected: " + coinCount;
    }
    public void CheckWinCondition()
    {
        if(coinCount >= totalCoin)
        {
            SceneManager.LoadScene("GameWin");
        }
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("GameLose");
    }
    public void Timer()
    {
        timer -= Time.deltaTime;
        timeText.text = "Time Left: " + timer;
    }
    public void TimeLose()
    {
        if(timer <= 0f)
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}

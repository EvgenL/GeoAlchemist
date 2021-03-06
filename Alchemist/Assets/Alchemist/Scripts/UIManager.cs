﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text ScoreText;

    private void Awake()
    {
        Instance = this;
    }
    public void UpdateScore(int score)
    {
        ScoreText.text = "Score: " + score;
    }
}

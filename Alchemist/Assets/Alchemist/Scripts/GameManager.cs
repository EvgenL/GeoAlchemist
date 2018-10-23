using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        LoadData();
    }

    #endregion

    public UIManager Ui;

    public int Score;

    private void LoadData()
    {
        Score = PlayerPrefs.GetInt("Score");
        Ui.UpdateScore(Score);
    }

    private void SaveData()
    {
        print("Player Data Saved.");
        PlayerPrefs.SetInt("Score", Score);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
            SaveData();
    }


    public void AddScore(int value = 1)
    {
        Score += value;
        Ui.UpdateScore(Score);
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int currentScore = 0;
    public static Action OnHitSquare = delegate{};

    void Start()
    {
        SetScoreText(currentScore);
    }

    void OnEnable()
    {
        OnHitSquare += IncreaseScore;
    }   

    void OnDisable()
    {
        OnHitSquare -= IncreaseScore;
    }

    void SetScoreText(int score)
    {
        scoreText.text = "Score : " + score;
    }


    void IncreaseScore()
    {
        currentScore++;
        SetScoreText(currentScore);
    } 
}

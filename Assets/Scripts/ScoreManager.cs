using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text enemyText;
    private int currentScore = 0;
    private int enemyScore = 0;

    
    public static Action OnHitSquare = delegate{};
    public static Action OnHitEnemy = delegate { };
    public static Action OnEnemyScore = delegate { };
    void Start()
    {
        SetScoreText(currentScore);
        SetEnemyScore(enemyScore);
    }

    void OnEnable()
    {
        OnHitSquare += IncreaseScore;
        OnEnemyScore += IncreaseEnemyScore;
    }   

    void OnDisable()
    {
        OnHitSquare -= IncreaseScore;
        OnEnemyScore -= IncreaseEnemyScore;
    }

    void SetScoreText(int score)
    {
        scoreText.text = "<color=blue>Your</color> Score : " + score;
    }

    void SetEnemyScore(int score)
    {
        if (enemyText == null) return;
        enemyText.text = "<color=red>Enemy</color> Score : " + score;
    }
    
    void IncreaseScore()
    {
        currentScore++;
        SetScoreText(currentScore);
        
        
    } 
    
    void IncreaseEnemyScore()
    {
        enemyScore++;
        SetEnemyScore(enemyScore);
    }
}

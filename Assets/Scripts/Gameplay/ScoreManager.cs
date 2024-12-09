using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent <int> OnScoreChanged;
    [SerializeField] private int totalScore;
    [SerializeField] private int highestScore;

    [Header("Score Values")]
    [SerializeField] private int scorePerEnemy;
    [SerializeField] private int scorePerCoin;
    [SerializeField] private int scorePerPowerUp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore(ScoreType action)
    {
        switch (action)
        {
            case ScoreType.EnemyKilled:
                totalScore += scorePerEnemy;
                break;
            case ScoreType.CoinCollected:
                totalScore += scorePerCoin;
                break;
            case ScoreType.PowerUpCollected:
                totalScore += scorePerPowerUp;
                break;
                /*
                }
                if (action == ScoreType.EnemyKilled)
                {
                    totalScore += scorePerEnemy;
                }
                else if (action == ScoreType.CoinCollected)
                {
                    totalScore += scorePerCoin;
                }
                else if (action == ScoreType.PowerUpCollected)
                {
                    totalScore += scorePerPowerUp;
                }
                */
        }

        OnScoreChanged.Invoke(totalScore);
    }
}


using System.Collections;
using System.Linq;
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

    [SerializeField] private List<ScoreData> allScores = new List<ScoreData>();
    [SerializeField] private ScoreData latestScore;

    // Start is called before the first frame update
    void Start()
    {
        Player playerObject = FindObjectOfType<Player>();
        playerObject.healthValue.OnDied.AddListener(RegisterScore);

        highestScore = PlayerPrefs.GetInt("HighScore");

        //AT start of the game
        // Retreive the string from player prefs 
        string latestScoreInJson = PlayerPrefs.GetString("LatestScore");
        //and try to convert it back into a ScoreData object/class
        latestScore = JsonUtility.FromJson<ScoreData>(latestScoreInJson);
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

    private void RegisterScore() //when player dies 
    {
        //Create an object filled with information 
        latestScore = new ScoreData("CC", totalScore);
       
        //Convert the object (class) into a string in json format
        string latestScoreInJson = JsonUtility.ToJson(latestScore);

        //save that string into PlayerPrefs
        PlayerPrefs.SetString("LatestScore", latestScoreInJson);


        if (totalScore > highestScore)
        {
            //WE GOT A NEW HIGH SCORE
            highestScore = totalScore;
            PlayerPrefs.SetInt("HighScore", highestScore); 
        }
    }
}


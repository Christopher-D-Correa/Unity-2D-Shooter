using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI scoreText;
    Player playerObject;

    private void Start()
    {
        FindObjectOfType<ScoreManager>().OnScoreChanged.AddListener(UpdateScoreValue);

        playerObject = FindObjectOfType<Player>();
        playerObject.healthValue.OnHealthChanged.AddListener(UpdateHealthValue);
        UpdateHealthValue(playerObject.healthValue.GetHealthValue());

    }
    // Start is called before the first frame update
    public void UpdateScoreValue(int score)
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void UpdateHealthValue(float health)
    {
        healthText.text = health.ToString();
    }
}

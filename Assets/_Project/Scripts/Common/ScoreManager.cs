using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int _score = 0;
    private int _eliminations = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI eliminationsText;


    private void Start()
    {
       
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }
        if (eliminationsText == null)
        {
            eliminationsText = GameObject.Find("EliminationsText").GetComponent<TextMeshProUGUI>();
        }
      
        UpdateScoreText();
        UpdateEliminationsText();
    }

  
    public void IncreaseScore(int amount)
    {
        _score += amount;
        UpdateScoreText();
    }

    
    public void DecreaseScore(int amount)
    {
        _score -= amount;
      
        _score = Mathf.Max(_score, 0);
        UpdateScoreText();
    }

    
    public int GetScore()
    {
        return _score;
    }

    
    public void IncreaseEliminations()
    {
        _eliminations++;
        UpdateEliminationsText();
    }

    
    public int GetEliminations()
    {
        return _eliminations;
    }

    
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + _score.ToString();
        }
    }

 
    private void UpdateEliminationsText()
    {
        if (eliminationsText != null)
        {
            eliminationsText.text = "Eliminations: " + _eliminations.ToString() + "/20";
        }
    }
}

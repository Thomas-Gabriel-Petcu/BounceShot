using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int _score;
    public int Score { get; private set; }
    public static ScoreManager Instance { get; private set; }
    private GameObject _textObj;
    private TMP_Text _tmpText;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        _textObj = GameObject.Find("ScoreText");
        _tmpText = _textObj.GetComponent<TMP_Text>();
    }

    public void IncreaseScore(int amount)
    {
        Score += amount;
        UpdateScore(Score);
    }

    public void UpdateScore(int score)
    {
        _tmpText.text = score.ToString();
    }

    public void SaveScore()
    {
        File.WriteAllText("save.txt",Score.ToString());
    }
}

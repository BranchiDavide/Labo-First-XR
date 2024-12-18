using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _score;

    public int Score
    {
        get { return _score; }
        set 
        {
            _score = value;

            CollectedObjsTxt.GetComponent<TextMeshProUGUI>().text = Score.ToString();
        }
    }

    [SerializeField]
    private TextMeshProUGUI CollectedObjsTxt;

    [SerializeField]
    private TextMeshProUGUI BestScoreTxt;

    private int _remainingObjects;

    public int RemainingObjects
    {
        get { return _remainingObjects; }
        set
        {
            _remainingObjects = value;

            RemainingObjsTxt.GetComponent<TextMeshProUGUI>().text = RemainingObjects.ToString();
        }
    }

    [SerializeField]
    private TextMeshProUGUI RemainingObjsTxt;

    void Start()
    {
        BestScoreTxt.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("BestScore").ToString();
        RemainingObjects = 8;
    }

    // Salvare il best score quando il gioco viene fermato
    void OnApplicationQuit()
    {
        int currentBestScore = PlayerPrefs.GetInt("BestScore");
        if(Score > currentBestScore)
        {
            PlayerPrefs.SetInt("BestScore", Score);
        }
    }
}

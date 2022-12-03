using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorePers : MonoBehaviour
{
    const int NUM_HIGH_SCORES = 5;
    const string NAME_KEY = "Player";
    const string SCORE_KEY = "Score";

    [SerializeField] string playerName;
    [SerializeField] int playerScore;
     public Text[] highscore;
     public Text[] name;



    // Start is called before the first frame update
    void Start()
    {
        playerName = PersisData.Instance.GetName();
        playerScore = PersisData.Instance.GetScore();
        SaveHighScores();
        ShowHighScores();
        // PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SaveHighScores()
    {

        for (int i = 0; i < NUM_HIGH_SCORES; i++)
        {
            string currentNameKey = NAME_KEY + i;
            string currentScoreKey = SCORE_KEY + i;

            if (PlayerPrefs.HasKey(currentScoreKey))
            {
                int currentScore = PlayerPrefs.GetInt(currentScoreKey);
                if (playerScore > currentScore)
                {
                    int tempScore = currentScore;
                    string tempName = PlayerPrefs.GetString(currentNameKey);

                    PlayerPrefs.SetString(currentNameKey, playerName);
                    PlayerPrefs.SetInt(currentScoreKey, playerScore);

                    playerName = tempName;
                    playerScore = tempScore;

                }
            }
            else
            {
                PlayerPrefs.SetString(currentNameKey, playerName);
                PlayerPrefs.SetInt(currentScoreKey, playerScore);
                return;
            }
        }
    }

    public void ShowHighScores()
    {
        for (int i = 0; i < NUM_HIGH_SCORES; i++)
        {

            highscore[i].text = PlayerPrefs.GetInt(SCORE_KEY+ (i + 1)).ToString();
            name[i].text = PlayerPrefs.GetString(NAME_KEY+ (i + 1));

        }
    }

}

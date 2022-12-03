using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour
{
    [SerializeField] int scoreNum = 0;

    const int DEFAULT_POINTS = 5;



    public Text userScore;

// private void Awake() {
//     nextSceneLevel= SceneManager.GetActiveScene().buildIndex + 1;
// }


    // Start is called before the first frame update
    void Start()
    {
        // nextSceneLevel=SceneManager.GetActiveScene().buildIndex + 1;
        scoreNum = PersisData.Instance.GetScore();

        if(SceneManager.GetActiveScene().buildIndex ==4){
          scoreNum=0;
        }
        // userScore.text="Score: " +scoreNum;
        DisplayScore();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int points)
    {
      // SceneManager.LoadScene(nextSceneLevel);
        scoreNum +=  points;
        PersisData.Instance.SetScore(scoreNum);
        DisplayScore();


    }


    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void DisplayScore()
    {

        userScore.text="Score: " +scoreNum;
    }

    public void DisplayLevel()
    {
        // sceneText.text = "Level: " + (level+1);
    }

    public void AdvanceLevel()
    {
        // SceneManager.LoadScene(level + 1);
    }
}

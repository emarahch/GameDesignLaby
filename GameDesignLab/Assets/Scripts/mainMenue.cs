using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GetName()
    {
        // SceneManager.LoadScene("level 1");
        SceneManager.LoadScene("getName");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("level 1");
    }


      public void GoToInstructions()
    {
        SceneManager.LoadScene("instructions");
    }


     public void GoToSettings()
    {
        SceneManager.LoadScene("settings");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenue");
    }

    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }
}

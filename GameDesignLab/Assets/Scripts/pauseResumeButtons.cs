using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseResumeButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

  public  void Pause ()
    {
        Time.timeScale = 0;
    }
public void Resume ()
    {
        Time.timeScale = 1;
    }

   public void mainMenue()
    {
        SceneManager.LoadScene("mainMenue");
    }
}

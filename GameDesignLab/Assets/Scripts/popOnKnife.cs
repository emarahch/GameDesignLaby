using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popOnKnife : MonoBehaviour
{
  public int nextSceneLevel;

    // Start is called before the first frame update
    private void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter2D (Collider2D collision)
    {
        // GameObject.FindGameObjectsWithTag("score").scoreKeeper();
        FindObjectOfType<scoreKeeper>().AddPoints(); // Find the Score script and tell it to increase the score
        Destroy(gameObject);
    }


}

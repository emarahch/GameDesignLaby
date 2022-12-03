using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knifeMovement : MonoBehaviour
{
  public float speed=2.0f;
  public int points;
  public AudioSource audioPlayer;

    // Start is called before the first frame update
private void awake(){
    audioPlayer = GetComponent<AudioSource>();
   // DontDestroyOnLoad(audioPlayer);

}

    void Start()
    {
         audioPlayer = PersisData.Instance.getAudio();
        // audioPlayer = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
          // transform.Translate(Vector2.right * Time.deltaTime);
            transform.Translate(Vector2.right * speed*Time.deltaTime);
    }


    public void OnTriggerEnter2D (Collider2D collider)
     {
   if (collider.gameObject.tag == "balloon"){
         audioPlayer.Play();
       }


  }

}

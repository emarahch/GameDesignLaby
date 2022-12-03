using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersisData : MonoBehaviour
{
  [SerializeField] int playerScore;
  [SerializeField] string playerName;
  [SerializeField] bool musicOnOrOffy;

  public AudioSource audioPlayer;
  // public AudioSource audioPlayerBg;

  public static  PersisData Instance;

  private void Awake()
  {
      if (Instance == null)
      {
          DontDestroyOnLoad(this);
          Instance = this;
      }
      else
      {
          Destroy(gameObject);
      }
  }

  // Start is called before the first frame update
  void Start()
  {
      audioPlayer = GetComponent<AudioSource>();

      playerScore = 0;
      playerName = "Noname";
      audioPlayer.volume=PlayerPrefs.GetFloat("musicVolume");
      musicOnOrOffy=PlayerPrefs.GetInt("musicOnOrOff")==1?true:false;


  }

  // Update is called once per frame
  void Update()
  {

  }

  public void SetName(string s)
  {
      playerName = s;
  }

  public void SetScore(int s)
  {
      playerScore = s;
  }

  public string GetName()
  {
      return playerName;
  }

  public int GetScore()
  {
      return playerScore;
  }
  public UnityEngine.AudioSource getAudio(){
    return audioPlayer;
  }

  // public UnityEngine.AudioSource getAudioBg(){
  //   return audioPlayerBg;
  // }








}

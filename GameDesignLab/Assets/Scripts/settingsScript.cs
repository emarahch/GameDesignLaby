using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsScript : MonoBehaviour
{

  //From youtube video
    // Start is called before the first frame update
    public AudioSource audioPlayer;
    public AudioSource audioPlayerBg;
    [SerializeField] Toggle musicOnOff;
    [SerializeField] Slider volumeSlider;


     void Start ()
     {
      audioPlayer=PersisData.Instance.getAudio();
      // audioPlayerBg=PersisData.Instance.getAudioBg();

      if(!PlayerPrefs.HasKey("musicVolume")){
         PlayerPrefs.SetFloat("musicVolume", 1);
         load();
      }else{
        load();
      }
    loadMusicOff();
     }

     public void toggleWoggle()
     {

       if (musicOnOff.isOn ==false){
         // audioPlayerBg.Stop();
         PlayerPrefs.SetInt("musicOnOrOff", musicOnOff.isOn?1:0);
         PlayerPrefs.SetFloat("musicVolume", 0);



         load();
         ChangeVolume();

       }
       if(musicOnOff.isOn ==true){
         PlayerPrefs.SetInt("musicOnOrOff",musicOnOff.isOn?1:0);
         PlayerPrefs.SetFloat("musicVolume", 1);

         load();
         ChangeVolume();

       }

     }

     public void ChangeVolume(){
       AudioListener.volume = volumeSlider.value;
       audioPlayer.Play();
       Save();
     }

     private void Save(){
       PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);

     }
     private void load(){
       volumeSlider.value= PlayerPrefs.GetFloat("musicVolume");
     }

     private void loadMusicOff(){
      musicOnOff.isOn =PlayerPrefs.GetInt("musicOnOrOff")==1?true:false;
     }


    // Update is called once per frame
    void Update()
    {
// if  (musicOnOff isOn){
//   audioPlayerBg.Play();
// }
    }
}

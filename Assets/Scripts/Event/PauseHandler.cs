using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour{
    private bool paused = false;
    public GameObject pausepanel;
    public GameObject settingspanel;
    public void Pause(){
        if (paused){
            if(settingspanel.activeSelf){
                settingspanel.SetActive(false);
            }else{
                paused = false;
                Time.timeScale = 1f;
                pausepanel.SetActive(false);
            }
        }else{
            paused = true;
            Time.timeScale = 0f;
            pausepanel.SetActive(true);
        }
    }
}

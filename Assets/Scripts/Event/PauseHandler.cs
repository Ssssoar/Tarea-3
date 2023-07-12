using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
                PlayerInput inputComp = GameObject.Find("Player").GetComponentInChildren<PlayerInput>();
                inputComp.SwitchCurrentActionMap("Moving Around");
            }
        }else{
            paused = true;
            PlayerInput inputComp = GameObject.Find("Player").GetComponentInChildren<PlayerInput>();
            inputComp.SwitchCurrentActionMap("Frozen");
            Time.timeScale = 0f;
            pausepanel.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class LightsEvent : MonoBehaviour{
    public bool lights = true; //true = lights on, false = lights off
    private bool prevFrame = true;
    public UnityEvent OnLights;
    public UnityEvent OnNoLights;

    public void LightsOn(){
        if (!lights){
            OnLights?.Invoke();
            lights = true;
            prevFrame = true;
        }
    }

    public void LightsOff(){
        if (lights){
            OnNoLights?.Invoke();
            lights = false;
            prevFrame = false;
        }
    }

    private void Update(){
        //for checking manual override on this variable, this should ONLY HAPPEN THROUGH THE INSPECTOR
        //this code is fucking messy. It's just debug stuff though
        if(prevFrame != lights){
            if (lights){
                lights = false;
                LightsOn();
            }else{
                lights = true;
                LightsOff();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedEvent : MonoBehaviour{
    public float maxTime;
    private float timer = -1f;
    public bool set = false;
    public UnityEvent TimeEvent;
    
    void Update(){
        if (timer == -1f){
            timer = maxTime;
        }
        if (set){
            timer -= Time.deltaTime;
            if (timer <= 0){
                TimeEvent?.Invoke();
                set = false;
                timer = maxTime;
            }
        }
    }
    
    public void Set(){
        timer = maxTime;
        set = true;  
    }
}

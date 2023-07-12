using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightHitEvent : MonoBehaviour{
    public UnityEvent InnerLightEvent;
    public UnityEvent OuterLightEvent;
    public UnityEvent ExitLightEvent;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Outer"){
            OuterLightEvent?.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D other){
        if (other.tag == "Inner"){
            InnerLightEvent?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if ((other.tag == "Inner") ||(other.tag == "Outer")){
            ExitLightEvent?.Invoke();
        }
    }
}

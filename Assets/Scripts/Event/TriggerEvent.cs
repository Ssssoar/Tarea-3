using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour{
    public UnityEvent Event;
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.tag == "Player"){
            Event?.Invoke();
        }
    }
}

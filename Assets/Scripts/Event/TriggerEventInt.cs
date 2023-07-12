using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class intEvent : UnityEvent<int> { }

public class TriggerEventInt : MonoBehaviour{
    public intEvent Event;
    public int i;
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.tag == "Player"){
            Event?.Invoke(i);
        }
    }
}

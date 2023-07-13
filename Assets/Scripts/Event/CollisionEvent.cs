using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour{
    public string tagToListenTo;
    public UnityEvent Event;
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == tagToListenTo){
            Event?.Invoke();
        }
    }
}
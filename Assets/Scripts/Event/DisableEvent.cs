using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisableEvent : MonoBehaviour{
    public UnityEvent disable;
    public UnityEvent enable;
    void OnDisable(){
        disable?.Invoke();
    }
    void OnEnable(){
        enable?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractEvent : MonoBehaviour{
    //EVERY INTERACTABLE MUST HAVE THIS SCRIPT
    public UnityEvent onInteract; //Whenever the player interacts with anything
    public void Interacted(){
        onInteract?.Invoke();
    }
}

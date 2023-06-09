using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[System.Serializable]
public class doubleFloatEvent : UnityEvent<float,float> { }

public class InputManager : MonoBehaviour{
    public doubleFloatEvent DirectionalInput; //Every frame while the horizontal and vertical axes are being pressed
    public UnityEvent AnyKeyStartPress; //ONLY the beginning of pressing ANY KEY
    public UnityEvent InteractKey;
    public UnityEvent StartFlashKey;
    public UnityEvent EndFlashKey;
    public UnityEvent CancelKey;
    /* ACTUALLY DON'T WORRY ABOUT HOW TO USE THE EVENTS
        They can be added from the inspector window, ask me (Ale) and I'll tell you how.
        All you need to do is make a separate function that'll handle the input, that way you don't clog any Update calls.
        After the function is made you add the appropriate GameObject from the input manager Game Object's Script on the inspector window.
        All you gotta type is the name of the function you've written (you can make multiple if you need any event to be considered for multiple things.
        Ask me if you need the clarification!
        Whichever function you make with this must receive the same type and ammount of args that the event has listed (<float, float>)
    */


    // Start is called before the first frame update
    void Start(){
    }

    void Update(){
        if (Keyboard.current.anyKey.wasPressedThisFrame){
            AnyKeyStartPress?.Invoke();
        }
        /*if (Input.GetButtonDown("Interact")){
            InteractKey?.Invoke();
        }
        if (Input.GetButtonDown("Flash")){
            StartFlashKey?.Invoke();
        }*/
        /*if (flash && )
        if (Input.GetButtonUp("Flash")){
            EndFlashKey?.Invoke();
        }*/
        /*if (Input.GetButtonDown("Cancel")){
            CancelKey?.Invoke();
        }*/
    }
    
    void OnInteract(){
        InteractKey?.Invoke();
    }
    
    void OnFlashLight(InputValue value){
        if (value.Get<float>() == 0f){
            EndFlashKey?.Invoke();
        }else{
            StartFlashKey?.Invoke();
        }
    }
    
    void OnPause(){
        CancelKey?.Invoke();
    }
    
    /*void FixedUpdate(){
        DirectionalInput?.Invoke(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    }*/
    
    void OnWalk(InputValue value){
        Vector2 val = value.Get<Vector2>();
        DirectionalInput?.Invoke(val.x,val.y);
    }
}

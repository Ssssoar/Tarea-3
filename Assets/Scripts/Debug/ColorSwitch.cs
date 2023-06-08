using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour{
    public Color color1;
    public Color color2;
    private SpriteRenderer sr; 
    private InputManager inputManager;
    //Debug Function that
    void Start(){
        sr = GetComponent<SpriteRenderer>();
        inputManager = FindObjectOfType<InputManager>();
        inputManager.AnyKeyStartPress.AddListener(Switch);
    }

    // Update is called once per frame
    void Update(){
    }

    void Switch(){
        if (sr.color == color1){
            sr.color = color2;
        }else {
            sr.color = color1;
        }
    }
}

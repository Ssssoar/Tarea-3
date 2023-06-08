using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour{
    public UnityEvent ArrowKeyPress; //Every frame while the horizontal and vertical axes are being pressed
    public UnityEvent AnyKeyStartPress; //ONLY the beginning of pressing ANY KEY

    /* TO USE ANY OF THOSE UnityEvent things!
     * In your script Start() method: 
        inputManager = FindObjectOfType<InputManager>();
        inputManager.[Name of the UnityEvent variable].AddListener([Name of the function you want to run]);

        This will make it so the function runs any time the UnityEvent is triggered
    */


    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        if ((Input.GetAxisRaw("Horizontal") != 0) || (Input.GetAxisRaw("Vertical") != 0)){
            ArrowKeyPress?.Invoke();
        }
        if (Input.anyKeyDown){
            AnyKeyStartPress?.Invoke();
        }
    }
}

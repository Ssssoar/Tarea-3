using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public bool freezeHorizontal = false;
    public bool freezeVertical = false;

    private void FixedUpdate(){
        // Calculate the desired position with offset
        if(target == null) {
            return;
        }
        Vector3 newPos = new Vector3(0f,0f,-10);
        // Smoothly transition to the desired position
        if (!freezeHorizontal) {
            newPos.x = target.position.x;
        }else{ 
            newPos.x = transform.position.x;
        }
        if (!freezeVertical){
            newPos.y = target.position.y;
        }else{
            newPos.y = transform.position.y;
        }


        // Set the camera position
        transform.position = newPos;
    }
    
    public void Hfreeze(){
        freezeHorizontal = true;
    }
    public void Vfreeze(){
        freezeVertical = true;
    }
    public void Hunfreeze(){
        freezeHorizontal = false;
    }
    public void Vunfreeze(){
        freezeVertical = false;
    }
}

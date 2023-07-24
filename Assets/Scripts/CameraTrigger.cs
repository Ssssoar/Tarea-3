using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour{
    public Transform cameraTrans;
    public Transform anchor; 
    public Transform newTarget;

    void OnTriggerEnter2D(Collider2D coll){
        if (coll.tag == "Player"){
            cameraTrans.position = anchor.position;
            if (newTarget != null){
                cameraTrans.gameObject.GetComponent<CameraControl>().ChangeTarget(newTarget);
            }
        }        
    }
}

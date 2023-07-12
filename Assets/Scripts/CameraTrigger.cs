using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour{
    public Transform cameraTrans;
    public Transform anchor; 
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.tag == "Player"){
            cameraTrans.position = anchor.position;
        }        
    }
}

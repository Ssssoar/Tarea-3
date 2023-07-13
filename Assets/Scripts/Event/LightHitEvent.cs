using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightHitEvent : MonoBehaviour{
    public UnityEvent InnerLightEvent;
    public UnityEvent OuterLightEvent;
    public UnityEvent ExitLightEvent;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Outer"){
            if (!CheckLightBlock(other)){
                OuterLightEvent?.Invoke();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other){
        if (other.tag == "Inner"){
            if (!CheckLightBlock(other)){
                InnerLightEvent?.Invoke();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if ((other.tag == "Inner") ||(other.tag == "Outer")){
            if (!CheckLightBlock(other)){
                ExitLightEvent?.Invoke();
            }
        }
    }
    
    private bool CheckLightBlock(Collider2D other){
        Vector2 direction = DirectionVect(transform.position,other.gameObject.transform.position);
        RaycastHit2D[] results = Physics2D.RaycastAll(transform.position,direction,direction.magnitude);
        bool blockedFlag = false;
        for (int i = 0 ; i < results.Length ; i++){
            GameObject obj = results[i].transform.gameObject;
            if(obj.GetComponentInChildren<UnityEngine.Rendering.Universal.ShadowCaster2D>() != null){
                blockedFlag = true;
                break;
            }
        }
        return blockedFlag;
    }
    
    private Vector2 DirectionVect(Vector2 origin,Vector2 target){
        return target - origin;
    }
}

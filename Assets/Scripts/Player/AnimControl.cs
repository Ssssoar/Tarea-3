using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour{
    public Animator anim;
    public Transform TurnObject;

    private LightsEvent lightsScript;

    private void Start(){
        lightsScript = GameObject.Find("Global Light 2D").GetComponent<LightsEvent>(); //Surely there's an easier way to do this.
    }


    public void TurnControl(float horizontal, float vertical){
        Vector2 vec = new Vector2(horizontal,vertical);
        if (vec.magnitude == 0){
            anim.SetBool("Walking", false);
            anim.SetFloat("Rotation",TurnObject.eulerAngles.z);
        }
        else{
            anim.SetBool("Walking",true);
            anim.SetFloat("Horizontal",horizontal);
            anim.SetFloat("Vertical",vertical);
        }
        anim.SetBool("Dark",!lightsScript.lights);
    }
}

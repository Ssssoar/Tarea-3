using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMessage : MonoBehaviour{
    public Animator animator;
    public string trigger;
    public void Message(){
        animator.SetTrigger(trigger);
    }
}

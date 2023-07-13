using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour{
    public int maxLife = 1;
    private int currentLife;
    public UnityEvent OnDie;
    
    void Start(){
        currentLife = maxLife;
    }
    
    public void LifeDown(){
        currentLife -= 1;
        if (currentLife <= 0){
            OnDie?.Invoke();
        }
    }
}

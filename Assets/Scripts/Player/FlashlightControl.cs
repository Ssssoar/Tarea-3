using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FlashlightControl : MonoBehaviour
{
    public GameObject lightEffect;
    private Light2D lightComp; //short for light component
    public float blinkTime = 0.5f;
    private bool appearing = false;
    private float timeLeft = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (appearing) {
            timeLeft -= Time.deltaTime;
            if ((Random.Range(0,1) == 0) || (blinkTime <= 0f)) {//Coin Flip
                lightEffect.SetActive(true);
            }else{
                lightEffect.SetActive(false);
            }
            if (blinkTime <= 0){
                appearing = false;
            }
        }
    }

    public void Appear(){
        appearing = true;
        timeLeft = blinkTime;
    }

    public void Disappear(){
        appearing = false;
        timeLeft = 0f;
        lightEffect.SetActive(false);
    }
}
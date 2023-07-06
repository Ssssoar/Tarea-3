using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashlightControl : MonoBehaviour
{
    public GameObject lightEffect;
    public bool flashlight; //Whether or not the player has the flashlight in their hands
    private bool malfunctioning = false; //Whether the flashlight is currently malfunctioning and therefore needs to be manually activated. Use Malfunction and Repair methods to set this.
    private UnityEngine.Rendering.Universal.Light2D lightComp; //short for light component
    public float blinkTime = 0.5f;
    private bool appearing = false;
    private float timeLeft = 0f;
    public PlayerMovement moveScript;
    public float playerSlowSpeed = 0.2f;
    private float playerFullSpeed;
    // Start is called before the first frame update
    void Start(){
        lightComp = lightEffect.GetComponent<UnityEngine.Rendering.Universal.Light2D>();
        playerFullSpeed = moveScript.speed;
    }

    // Update is called once per frame
    void Update(){
        if (appearing && malfunctioning) {
            timeLeft -= Time.deltaTime;
            lightComp.intensity = Random.Range(0f,1f);
            if (timeLeft <= 0){
                appearing = false;
                lightComp.intensity = 1f;
            }
        }
    }

    public void Appear(){
        if (malfunctioning && isActiveAndEnabled) {
            //slow down the player
            moveScript.speed = playerSlowSpeed;
            //Appear the flashlight
            appearing = true;
            timeLeft = blinkTime;
            lightEffect.SetActive(true);
        }
    }

    public void Disappear(){
        if (malfunctioning) {
            //Return player to full speed
            moveScript.speed = playerFullSpeed;
            //Dissappear the flashlight
            appearing = false;
            timeLeft = 0f;
            lightEffect.SetActive(false);
        }
    }

    public void Malfunction(){
        malfunctioning = true;
        appearing = false;
        lightEffect.SetActive(false);
    }

    public void Repair(){
        malfunctioning = false;
        appearing = false;
        lightEffect.SetActive(true);
        lightComp.intensity = 1f;
    }
}
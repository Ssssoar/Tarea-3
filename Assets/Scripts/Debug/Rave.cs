using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rave : MonoBehaviour{
    private bool activated;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start(){
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update(){
        if (activated){
            sr.color = new Color(Random.Range(0f,255f)/255,Random.Range(0f,255f)/255,Random.Range(0f,255f)/255,255f);
        }
    }
    public void Activate(){
        activated = true;
    }
}

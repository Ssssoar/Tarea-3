using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalLightControls : MonoBehaviour{
    private UnityEngine.Rendering.Universal.Light2D lightComp;
    public float ONintensity = 1f;
    public Color ONcolor;
    public float OFFintensity = 0.1f;
    public Color OFFcolor;
    // Start is called before the first frame update
    void Start(){
        lightComp = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }
    
    public void LightsOn(){
        lightComp.intensity = ONintensity;
        lightComp.color = ONcolor;
    }

    public void LightsOff(){
        lightComp.intensity = OFFintensity;
        lightComp.color = OFFcolor;
    }
}
